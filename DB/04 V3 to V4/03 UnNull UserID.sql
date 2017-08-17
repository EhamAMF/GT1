/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Treasury
	DROP CONSTRAINT FK_Treasury_Expense
GO
ALTER TABLE dbo.Expense SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Treasury
	DROP CONSTRAINT FK_Treasury_Invoice
GO
ALTER TABLE dbo.Invoice SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Treasury
	DROP CONSTRAINT FK_Treasury_Account
GO
ALTER TABLE dbo.Account SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Treasury
	DROP CONSTRAINT FK_Treasury_Payment
GO
ALTER TABLE dbo.Payment SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Treasury
	DROP CONSTRAINT FK_Treasury_OtherPayment
GO
ALTER TABLE dbo.OtherPayment SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Treasury
	(
	TreasuryID bigint NOT NULL IDENTITY (1, 1),
	TreasuryNumber bigint NOT NULL,
	MoneyDirectionID int NOT NULL,
	PaymentAmount decimal(18, 3) NOT NULL,
	PaymentDate datetime NOT NULL,
	Note nvarchar(500) NULL,
	AcountID bigint NOT NULL,
	InvoiceID bigint NULL,
	PaymentID bigint NULL,
	ExpenseID bigint NULL,
	OtherPaymentID bigint NULL,
	CurrentBalance decimal(18, 3) NULL,
	UserID bigint NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Treasury SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Treasury ON
GO
IF EXISTS(SELECT * FROM dbo.Treasury)
	 EXEC('INSERT INTO dbo.Tmp_Treasury (TreasuryID, TreasuryNumber, MoneyDirectionID, PaymentAmount, PaymentDate, Note, AcountID, InvoiceID, PaymentID, ExpenseID, OtherPaymentID, CurrentBalance, UserID)
		SELECT TreasuryID, TreasuryNumber, MoneyDirectionID, PaymentAmount, PaymentDate, Note, AcountID, InvoiceID, PaymentID, ExpenseID, OtherPaymentID, CurrentBalance, UserID FROM dbo.Treasury WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Treasury OFF
GO
DROP TABLE dbo.Treasury
GO
EXECUTE sp_rename N'dbo.Tmp_Treasury', N'Treasury', 'OBJECT' 
GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	PK_Treasury PRIMARY KEY CLUSTERED 
	(
	TreasuryID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	FK_Treasury_OtherPayment FOREIGN KEY
	(
	OtherPaymentID
	) REFERENCES dbo.OtherPayment
	(
	OtherPaymentID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	FK_Treasury_Payment FOREIGN KEY
	(
	PaymentID
	) REFERENCES dbo.Payment
	(
	PaymentID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	FK_Treasury_Account FOREIGN KEY
	(
	AcountID
	) REFERENCES dbo.Account
	(
	AccountID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	FK_Treasury_Invoice FOREIGN KEY
	(
	InvoiceID
	) REFERENCES dbo.Invoice
	(
	InvoiceID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Treasury ADD CONSTRAINT
	FK_Treasury_Expense FOREIGN KEY
	(
	ExpenseID
	) REFERENCES dbo.Expense
	(
	ExpenseID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
