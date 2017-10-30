CREATE TABLE [dbo].[Button](
	[BtnID] [int] NOT NULL,
	[StockID] [bigint] NOT NULL,
	[ColorID] [int] NULL,
	[UserID] [bigint] NOT NULL,
	[State] [bit] NOT NULL,
	[IDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Button] PRIMARY KEY CLUSTERED 
(
	[BtnID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

;

ALTER TABLE [dbo].[Button]  WITH CHECK ADD  CONSTRAINT [FK_Button_Stock] FOREIGN KEY([StockID])
REFERENCES [dbo].[Stock] ([StockID])
;

ALTER TABLE [dbo].[Button] CHECK CONSTRAINT [FK_Button_Stock]
;

ALTER TABLE [dbo].[Button]  WITH CHECK ADD  CONSTRAINT [FK_Button_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
;

ALTER TABLE [dbo].[Button] CHECK CONSTRAINT [FK_Button_Users]
;

ALTER TABLE [dbo].[Button] ADD  CONSTRAINT [DF_Button_State]  DEFAULT ((1)) FOR [State]
;

ALTER TABLE [dbo].[Button] ADD  CONSTRAINT [DF_Button_IDateTime]  DEFAULT (getdate()) FOR [IDateTime]
;


