# Vb.Net-Order-System-Example

A simple Order System With Vb.Net and SQL Server

# Database Structure

# produtos
> CREATE TABLE [dbo].[produtos](
> 
> 	[pro_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[pro_nome] [varchar](50) NOT NULL,
> 
> 	[pro_foto] [text] NULL,
> 
> 	[cat_id] [int] NOT NULL,
> 
> 	[mar_id] [int] NULL,
> 
>  CONSTRAINT [PK_produtos] PRIMARY KEY CLUSTERED 
> 
> (
> 
> 	[pro_id] ASC
> 
> )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
> 
> 
> 
> GO
> 
> 
> 
> ALTER TABLE [dbo].[produtos]  WITH CHECK ADD  CONSTRAINT [FK_produtos_categorias] FOREIGN KEY([cat_id])
> 
> REFERENCES [dbo].[categorias] ([cat_id])
> 
> GO
> 
> 
> 
> ALTER TABLE [dbo].[produtos] CHECK CONSTRAINT [FK_produtos_categorias]
> 
> GO
> 
> 
# produtos_itens
> CREATE TABLE [dbo].[produtos_tamanhos](
> 
> 	[tam_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[tam_nome] [varchar](50) NOT NULL,
> 
> 	[tam_valor] [float] NOT NULL,
> 
> 	[pro_id] [int] NOT NULL,
> 
> 	[tam_qtde_estoque] [int] NOT NULL,
> 
> 	CONSTRAINT [PK_produtos_tamanho] PRIMARY KEY CLUSTERED 
> 
> 	(
> 	
> 
> 	[tam_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY]
> 
> 
> GO
> 
> 
> ALTER TABLE [dbo].[produtos_tamanhos]  WITH CHECK ADD  CONSTRAINT [FK_produtos_tamanhos_produtos] FOREIGN KEY([pro_id])
> 
> REFERENCES [dbo].[produtos] ([pro_id])
> 
> GO
> 
> 
> 
> ALTER TABLE [dbo].[produtos_tamanhos] CHECK CONSTRAINT [FK_produtos_tamanhos_produtos]
> 
> GO
> 
> 
# categorias
> 
> CREATE TABLE [dbo].[categorias](
> 
> 	[cat_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[cat_nome] [varchar](50) NOT NULL,
> 
> 	[cat_ordem] [smallint] NULL,
> 
> 	CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED 
> 
> 	(
> 	
> 	[cat_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY]
> 
> 	
> 	GO
> 
> 
# marcas
> 
> CREATE TABLE [dbo].[marcas](
> 
> 	[mar_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[mar_nome] [varchar](50) NOT NULL,
> 
> 	[mar_ordem] [smallint] NULL,
> 
> 	[mar_foto] [text] NOT NULL,
> 
> 	CONSTRAINT [PK_marcas] PRIMARY KEY CLUSTERED 
> 
> 	(
> 
> 	[mar_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
> 
> 	
> 
> 	GO
> 
> 	
# clientes
> 
> CREATE TABLE [dbo].[clientes](
> 
> 	[cli_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[cli_nome] [varchar](100) NOT NULL,
> 
> 	[cli_cpf] [varchar](14) NOT NULL,
> 
> 	[cli_nascimento] [date] NULL,
> 
> 	CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
> 
> 	(
> 
> 	[cli_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY]
> 
> 	
# pedidos
> 
> CREATE TABLE [dbo].[pedidos](
> 
> 	[ped_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[ped_data] [datetime] NOT NULL,
> 
> 	[cli_id] [int] NOT NULL,
> 
> 	CONSTRAINT [PK_pedidos] PRIMARY KEY CLUSTERED 
> 
> 	(
> 
> 	[ped_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY]
> 
> 
> 	GO
> 
> 	ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_clientes] FOREIGN KEY([cli_id])
> 
> 	REFERENCES [dbo].[clientes] ([cli_id])
> 
> 	GO
> 
> ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_clientes]
> 
> 	GO
> 
> 
# pedidos_itens
> 
> CREATE TABLE [dbo].[pedidos_itens](
> 
> 	[item_id] [int] IDENTITY(1,1) NOT NULL,
> 
> 	[item_qtde] [int] NOT NULL,
> 
> 	[item_valor_unit] [float] NOT NULL,
> 
> 	[item_valor_total] [float] NOT NULL,
> 
> 	[pro_id] [int] NOT NULL,
> 
> 	[ped_id] [int] NOT NULL,
> 
> 	CONSTRAINT [PK_pedidos_itens] PRIMARY KEY CLUSTERED 
> 
> 	(
> 
> 	[item_id] ASC
> 
> 	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
> 
> 	) ON [PRIMARY]
> 
> 
> 	GO
> 
> 
> 	ALTER TABLE [dbo].[pedidos_itens]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_itens_pedidos] FOREIGN KEY([ped_id])
> 
> 	REFERENCES [dbo].[pedidos] ([ped_id])
> 
> 	GO
> 	
> 
> 	ALTER TABLE [dbo].[pedidos_itens] CHECK CONSTRAINT [FK_pedidos_itens_pedidos]
> 
> 	GO
> 
> 
> 	ALTER TABLE [dbo].[pedidos_itens]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_itens_produtos] FOREIGN KEY([pro_id])
> 
> 	REFERENCES [dbo].[produtos] ([pro_id])
> 
> 	GO
> 
> 	ALTER TABLE [dbo].[pedidos_itens] CHECK CONSTRAINT [FK_pedidos_itens_produtos]
> 
> 	GO