# Тествое задание по созданию простого приложение, с БД на MS Sql Server Express, и клиентскую часть на WPF. 

## Задание:
Схема таблиц : 
      * Заказы (Номер, Дата, Сумма, СуммаОплаты) 
      * Приход денег (Номер, Дата, Сумма, Остаток) 
      * Платежи (Заказ + Приход  денег, Сумма платежа) 
Под приходом денег понимаются самостоятельные единицы взносов, которые позже можно использовать для платежей. Интерфейс должен реализовать возможность выбора прихода денег и привязки к заказу. При этом «СуммаОплаты» заказа должна увеличиваться, а «Остаток» прихода денег уменьшаться (логику необходимо реализовать с помощью триггеров БД). Заказ может быть оплачен несколькими платежами, а также одни и те же приходы денег  могут быть использованы в нескольких платежах, пока остаток не закончится. Так же необходимо учитывать ситуацию, когда два пользователя пытаются привязать оплату одновременно к одному заказу.


## Описание реализованного клиентского приложения на WPF и приложение реализованное хранящее миграции и модели, ипосльзующее EF Core 
При запуске производится появлется окно требущие логин и пароль пользователя, после входа в аккаунт, пользователь может выбрать заказ и транш денеженый и создать платеж по заказу

## Реализованные приложения работают SQL Server
В БД хранится 4 таблицы, код для создания таблиц

###Orders
```sql
CREATE TABLE [dbo].[Orders] (
    [IdOrder]   UNIQUEIDENTIFIER NOT NULL,
    [OrderDate] DATETIME2 (7)    NOT NULL,
    [Sum]       DECIMAL (18, 2)  NOT NULL,
    [Balance]   DECIMAL (18, 2)  NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([IdOrder] ASC)
);
```
###Payments
```sql
CREATE TABLE [dbo].[Payments] (
    [IdOrder]      UNIQUEIDENTIFIER NOT NULL,
    [IdTranche]    UNIQUEIDENTIFIER NOT NULL,
    [TotalPayment] DECIMAL (18, 2)  NOT NULL,
    CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([IdOrder] ASC, [IdTranche] ASC),
    CONSTRAINT [FK_Payments_Orders_IdOrder] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Orders] ([IdOrder]) ON DELETE CASCADE,
    CONSTRAINT [FK_Payments_Tranches_IdTranche] FOREIGN KEY ([IdTranche]) REFERENCES [dbo].[Tranches] ([IdTranche]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Payments_IdTranche]
    ON [dbo].[Payments]([IdTranche] ASC);


GO
CREATE TRIGGER UpdateResidual
ON [dbo].[Payments]
AFTER INSERT
AS
BEGIN
    UPDATE [dbo].[Tranches]
    SET Residual = CASE 
                     WHEN t.Residual - inserted.TotalPayment < 0 
                       THEN 0 
                     ELSE t.Residual - inserted.TotalPayment 
                   END
    FROM [dbo].[Tranches] t
    JOIN inserted ON t.IdTranche = inserted.IdTranche
    WHERE t.IdTranche = inserted.IdTranche
END
GO

CREATE TRIGGER UpdateBalance
ON [dbo].[Payments]
AFTER INSERT
AS
BEGIN
    UPDATE [dbo].[Orders]
    SET Balance = CASE 
                    WHEN o.Balance + inserted.TotalPayment > o.Sum 
                      THEN o.Sum 
                    ELSE o.Balance + inserted.TotalPayment 
                  END
    FROM [dbo].[Orders] o
    JOIN inserted ON o.IdOrder = inserted.IdOrder
    WHERE o.IdOrder = inserted.IdOrder
END
```
###Tranches
```sql
CREATE TABLE [dbo].[Tranches] (
    [IdTranche]   UNIQUEIDENTIFIER NOT NULL,
    [TrancheDate] DATETIME2 (7)    NOT NULL,
    [Sum]         DECIMAL (18, 2)  NOT NULL,
    [Residual]    DECIMAL (18, 2)  NOT NULL,
    CONSTRAINT [PK_Tranches] PRIMARY KEY CLUSTERED ([IdTranche] ASC)
);
```
###Users
```sql
CREATE TABLE [dbo].[Users] (
    [UserId]           UNIQUEIDENTIFIER NOT NULL,
    [Name]             NVARCHAR (MAX)   NOT NULL,
    [Password]         NVARCHAR (MAX)   NOT NULL,
    [UserOrdersIdGuid] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Users_Orders_UserOrdersIdGuid] FOREIGN KEY ([UserOrdersIdGuid]) REFERENCES [dbo].[Orders] ([IdOrder]) ON DELETE CASCADE
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_UserOrdersIdGuid]
    ON [dbo].[Users]([UserOrdersIdGuid] ASC);
```

