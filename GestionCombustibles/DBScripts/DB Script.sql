USE [Combustibles]
GO
/****** Object:  User [aries]    Script Date: 12/07/2017 22:47:14 ******/
CREATE USER [aries] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [aries]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[DNI_CLIE] [char](8) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[DIRECCION] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI_CLIE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[CODIGO_PRO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[MARCA] [varchar](50) NULL,
	[DESCRIPCION] [varchar](50) NULL,
	[PRECIO] [money] NULL,
	[CANTIDAD] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CODIGO_PRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_cliente]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_documento] [int] NULL,
	[v_num_documento] [varchar](11) NULL,
	[v_nom_cliente] [varchar](50) NULL,
	[v_direccion_cliente] [varchar](100) NULL,
	[id_departamento] [int] NULL,
	[id_provincia] [int] NULL,
	[id_distrito] [int] NULL,
	[v_ubigeo] [varchar](50) NULL,
	[i_chk_promo_vigentes] [int] NULL,
	[i_chk_aceptar_vtas_credito] [int] NULL,
	[d_linea_credito] [decimal](18, 2) NULL,
	[d_credito_utilizado] [decimal](18, 2) NULL,
	[d_credito_disponible] [decimal](18, 2) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_comprobante]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_comprobante](
	[id_comprobante] [int] IDENTITY(1,1) NOT NULL,
	[v_tipo_comprobante] [varchar](50) NULL,
	[v_serie_comprobante] [varchar](50) NULL,
	[v_numero_comprobante] [varchar](50) NULL,
	[v_num_documento_cliente] [varchar](11) NULL,
	[v_fecha_hora_comprobante] [varchar](50) NULL,
	[v_placa_comprobante] [varchar](50) NULL,
	[v_linea_cred_soles_comprobante] [varchar](50) NULL,
	[v_cod_operador] [varchar](50) NULL,
	[v_cod_turno] [varchar](50) NULL,
	[v_tarjeta_soles_comprobante] [varchar](50) NULL,
	[v_linea_cred_comprobante] [nchar](10) NULL,
	[d_total_gravado_comprobante] [decimal](18, 4) NULL,
	[d_total_gratuito_comprobante] [decimal](18, 4) NULL,
	[d_total_inafecto_comprobante] [decimal](18, 4) NULL,
	[d_total_exonerado_comprobante] [decimal](18, 4) NULL,
	[d_dscnto_global_comprobante] [decimal](18, 4) NULL,
	[d_total_venta_soles_comprobante] [decimal](18, 4) NULL,
	[d_total_igv_soles_comprobante] [decimal](18, 4) NULL,
	[d_total_isc_soles_comprobante] [decimal](18, 4) NULL,
	[d_efectivo_soles_comprobante] [decimal](18, 4) NULL,
	[d_tipo_cambio_comprobante] [decimal](18, 4) NULL,
	[d_efectivo_dolares_comprobante] [decimal](18, 4) NULL,
	[d_pago_comprobante] [decimal](18, 4) NULL,
	[d_vuelto_comprobante] [decimal](18, 4) NULL,
	[v_monto_letras_comprobante] [varchar](100) NULL,
	[v_hash_comprobante] [varchar](200) NULL,
	[v_msjrpta_comprobante] [varchar](200) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [nchar](10) NULL,
 CONSTRAINT [PK_tb_comprobante] PRIMARY KEY CLUSTERED 
(
	[id_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_comprobante_detalle]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_comprobante_detalle](
	[id_comprobante] [int] NOT NULL,
	[id_item_comprobante] [int] NOT NULL,
	[v_cod_isla] [varchar](50) NULL,
	[v_cod_surtidor] [varchar](50) NULL,
	[v_cod_lados] [varchar](50) NULL,
	[v_cod_manguera] [varchar](50) NULL,
	[v_cod_producto] [varchar](20) NULL,
	[d_precio_unitario_dcomprobante] [decimal](18, 4) NULL,
	[d_cantidad_dcomprobante] [decimal](18, 4) NULL,
	[d_subtotal_gravado_comprobante] [decimal](18, 4) NULL,
	[d_subtotal_gratuito_comprobante] [decimal](18, 4) NULL,
	[d_subtotal_inafecto_comprobante] [decimal](18, 4) NULL,
	[d_subtotal_exonerado_comprobante] [decimal](18, 4) NULL,
	[d_subtotal_item_comprobante] [decimal](18, 4) NULL,
	[i_flg_afecto_igv] [int] NULL,
	[d_igv_item_dcomprobante] [decimal](18, 4) NULL,
	[i_flg_afecto_isc] [int] NULL,
	[d_isc_item_dcomprobante] [decimal](18, 4) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_comprobante_detalle] PRIMARY KEY CLUSTERED 
(
	[id_comprobante] ASC,
	[id_item_comprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_departamento]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_departamento](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[v_desc_departamento] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_departamento] PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_distrito]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_distrito](
	[id_distrito] [int] IDENTITY(1,1) NOT NULL,
	[id_provincia] [int] NULL,
	[v_desc_distrito] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_distrito] PRIMARY KEY CLUSTERED 
(
	[id_distrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_documentos]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_documentos](
	[id_documento] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_documento] [varchar](20) NULL,
	[v_deno_documento] [varchar](50) NULL,
	[v_serie_documento] [varchar](4) NULL,
	[v_num_documento] [varchar](20) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_documentos] PRIMARY KEY CLUSTERED 
(
	[id_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_empresa]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[v_num_documento] [varchar](50) NULL,
	[v_nom_empresa] [varchar](100) NULL,
	[v_direccion_empresa] [varchar](200) NULL,
	[id_departamento] [int] NULL,
	[id_provincia] [int] NULL,
	[id_distrito] [int] NULL,
	[v_ubigeo] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
	[v_texto] [varchar](50) NULL,
 CONSTRAINT [PK_tb_empresa] PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_empresa_calcimp]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_empresa_calcimp](
	[id_empresa] [int] NOT NULL,
	[id_calcimp] [int] NOT NULL,
	[d_calculoIGV_calcimp] [decimal](18, 4) NULL,
	[d_calculoISC_calcimp] [decimal](18, 4) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_empresa_calcimp] PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC,
	[id_calcimp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_islas]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_islas](
	[id_isla] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_isla] [varchar](50) NULL,
	[v_denominacion_isla] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_isla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_lados]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_lados](
	[id_lados] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_lados] [varchar](50) NULL,
	[v_denominacion_lados] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_lados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_mangueras]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_mangueras](
	[id_manguera] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_manguera] [varchar](50) NULL,
	[v_denominacion_manguera] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_mangueras] PRIMARY KEY CLUSTERED 
(
	[id_manguera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_nivel]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_nivel](
	[id_nivel] [int] IDENTITY(1,1) NOT NULL,
	[v_desc_nivel] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_nivel] PRIMARY KEY CLUSTERED 
(
	[id_nivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_nivel_dcto_cliente]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_nivel_dcto_cliente](
	[id_nivel_dto_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_producto] [int] NULL,
	[d_cant_minima] [decimal](18, 0) NULL,
	[d_dto_cantidad] [decimal](18, 0) NOT NULL,
	[i_estado_registro] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_operador]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_operador](
	[id_operador] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_operador] [varchar](50) NULL,
	[v_nombre_operador] [varchar](100) NULL,
	[v_apepaterno_operador] [varchar](50) NULL,
	[v_apematerno_operador] [varchar](50) NULL,
	[id_nivel] [int] NULL,
	[v_usuario_operador] [varchar](50) NULL,
	[v_clave_operador] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_operador] PRIMARY KEY CLUSTERED 
(
	[id_operador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_operador_usuario]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_operador_usuario](
	[id_operador_usuario] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_operador_usuario] [varchar](50) NULL,
	[v_nombre_operador_usuario] [varchar](50) NULL,
	[id_nivel] [int] NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
	[v_clave_operador_usuario] [varchar](10) NULL,
 CONSTRAINT [PK_T] PRIMARY KEY CLUSTERED 
(
	[id_operador_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_producto]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_producto] [varchar](20) NULL,
	[v_nom_producto] [varchar](50) NULL,
	[d_p_venta] [decimal](18, 2) NULL,
	[d_c_compra] [decimal](18, 2) NULL,
	[i_flg_afecto_igv] [int] NULL,
	[i_flg_afecto_isc] [int] NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
	[v_uni_med] [varchar](50) NULL,
 CONSTRAINT [PK_tb_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_provincia]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_provincia](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[id_departamento] [int] NULL,
	[v_desc_provincia] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_provincia] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_surtidor]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_surtidor](
	[id_surtidor] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_surtidor] [varchar](50) NULL,
	[v_denominacion_surtidor] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_surtidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tablas_tipo]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tablas_tipo](
	[id_tabla_tipo] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_tabla_tipo] [varchar](50) NULL,
	[v_item_tabla_tipo] [varchar](50) NULL,
	[v_denominacion_tabla_tipo] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_tablas_tipo] PRIMARY KEY CLUSTERED 
(
	[id_tabla_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tcambio]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tcambio](
	[id_tcambio] [int] IDENTITY(1,1) NOT NULL,
	[v_fecha] [varchar](10) NULL,
	[d_venta] [decimal](18, 2) NULL,
	[d_compra] [decimal](18, 2) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_tcambio] PRIMARY KEY CLUSTERED 
(
	[id_tcambio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_tipo_documento]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tipo_documento](
	[id_tipo_documento] [int] IDENTITY(1,1) NOT NULL,
	[v_desc_tipo_documento] [varchar](50) NULL,
	[v_abrev_tipo_documento] [varchar](5) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
 CONSTRAINT [PK_tb_tipo_documento] PRIMARY KEY CLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_Tipo_Perfil]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Tipo_Perfil](
	[id_tipo_perfil] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_perfil] [varchar](50) NULL,
	[id_registro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_turnos]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_turnos](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[v_cod_turno] [varchar](50) NULL,
	[v_denominacion_turno] [varchar](50) NULL,
	[id_usuario_creacion] [int] NULL,
	[v_fecha_creacion] [varchar](50) NULL,
	[id_usuario_modificacion] [int] NULL,
	[v_fecha_modificacion] [varchar](50) NULL,
	[i_estado_registro] [int] NULL,
	[v_hora_inicio] [varchar](8) NULL,
	[v_hora_fin] [varchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_Usuarios]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[v_nom_usuario] [varchar](20) NULL,
	[v_usuario] [varchar](20) NULL,
	[v_clave_usuario] [varchar](20) NULL,
	[i_estado_registro] [int] NULL,
	[id_tipo_perfil] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[DNI_US] [char](8) NOT NULL,
	[USUARIO] [varchar](20) NULL,
	[PASSWOR] [varchar](20) NULL,
	[CATEGORIA] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI_US] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENDEDORES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENDEDORES](
	[DNI_US] [char](8) NOT NULL,
	[NOMBRE] [varchar](80) NULL,
	[DIRECCION] [varchar](50) NULL,
	[TELEFONO] [char](13) NULL,
	[TURNO] [varchar](30) NULL,
	[SEXO] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[DNI_US] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VENTAS_REALIZADAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VENTAS_REALIZADAS](
	[NUMERO_VENTA] [int] IDENTITY(1,1) NOT NULL,
	[DNI_CLIE] [char](8) NULL,
	[NOMBRE_CLI] [varchar](50) NULL,
	[CODIGO_PRO] [int] NULL,
	[TOTAL] [money] NULL,
	[DNI_US] [char](8) NULL,
	[FECHA] [date] NULL,
	[CANCELADO] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[NUMERO_VENTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCTO] ON 

INSERT [dbo].[PRODUCTO] ([CODIGO_PRO], [NOMBRE], [MARCA], [DESCRIPCION], [PRECIO], [CANTIDAD]) VALUES (1, N'CELULAR', N'LG', N'COLOR AZUL 3', 230.0000, 150)
SET IDENTITY_INSERT [dbo].[PRODUCTO] OFF
SET IDENTITY_INSERT [dbo].[tb_cliente] ON 

INSERT [dbo].[tb_cliente] ([id_cliente], [id_tipo_documento], [v_num_documento], [v_nom_cliente], [v_direccion_cliente], [id_departamento], [id_provincia], [id_distrito], [v_ubigeo], [i_chk_promo_vigentes], [i_chk_aceptar_vtas_credito], [d_linea_credito], [d_credito_utilizado], [d_credito_disponible], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (30, 1, N'70840118', N'Julio Avila', N'Av. xxxxx 999', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'2017-07-11', 1, N'2017-07-11', 1)
SET IDENTITY_INSERT [dbo].[tb_cliente] OFF
SET IDENTITY_INSERT [dbo].[tb_comprobante] ON 

INSERT [dbo].[tb_comprobante] ([id_comprobante], [v_tipo_comprobante], [v_serie_comprobante], [v_numero_comprobante], [v_num_documento_cliente], [v_fecha_hora_comprobante], [v_placa_comprobante], [v_linea_cred_soles_comprobante], [v_cod_operador], [v_cod_turno], [v_tarjeta_soles_comprobante], [v_linea_cred_comprobante], [d_total_gravado_comprobante], [d_total_gratuito_comprobante], [d_total_inafecto_comprobante], [d_total_exonerado_comprobante], [d_dscnto_global_comprobante], [d_total_venta_soles_comprobante], [d_total_igv_soles_comprobante], [d_total_isc_soles_comprobante], [d_efectivo_soles_comprobante], [d_tipo_cambio_comprobante], [d_efectivo_dolares_comprobante], [d_pago_comprobante], [d_vuelto_comprobante], [v_monto_letras_comprobante], [v_hash_comprobante], [v_msjrpta_comprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'03', N'', N'', N'20100039207', N'12/07/2017', N'', N'', N'O0001', N'c003', N'', N'          ', CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(8.4700 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'OCHO CON 47/100', N'r4Zt7ET2Vy5DBCBh3+xQHpeNs/I=', NULL, 1, N'Jul 12 2017 12:43PM', NULL, NULL, N'1         ')
INSERT [dbo].[tb_comprobante] ([id_comprobante], [v_tipo_comprobante], [v_serie_comprobante], [v_numero_comprobante], [v_num_documento_cliente], [v_fecha_hora_comprobante], [v_placa_comprobante], [v_linea_cred_soles_comprobante], [v_cod_operador], [v_cod_turno], [v_tarjeta_soles_comprobante], [v_linea_cred_comprobante], [d_total_gravado_comprobante], [d_total_gratuito_comprobante], [d_total_inafecto_comprobante], [d_total_exonerado_comprobante], [d_dscnto_global_comprobante], [d_total_venta_soles_comprobante], [d_total_igv_soles_comprobante], [d_total_isc_soles_comprobante], [d_efectivo_soles_comprobante], [d_tipo_cambio_comprobante], [d_efectivo_dolares_comprobante], [d_pago_comprobante], [d_vuelto_comprobante], [v_monto_letras_comprobante], [v_hash_comprobante], [v_msjrpta_comprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, N'03', N'', N'', N'20100039207', N'12/07/2017', N'', N'0.00', N'O0001', N'c003', N'0.00', N'0.00      ', CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(33.8800 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(33.8800 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(33.8800 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'TREINTA Y TRES CON 88/100', N'T0OsY69eB76ZXR/PInp9o9iM6kA=', NULL, 1, N'Jul 12 2017  9:48PM', NULL, NULL, N'1         ')
INSERT [dbo].[tb_comprobante] ([id_comprobante], [v_tipo_comprobante], [v_serie_comprobante], [v_numero_comprobante], [v_num_documento_cliente], [v_fecha_hora_comprobante], [v_placa_comprobante], [v_linea_cred_soles_comprobante], [v_cod_operador], [v_cod_turno], [v_tarjeta_soles_comprobante], [v_linea_cred_comprobante], [d_total_gravado_comprobante], [d_total_gratuito_comprobante], [d_total_inafecto_comprobante], [d_total_exonerado_comprobante], [d_dscnto_global_comprobante], [d_total_venta_soles_comprobante], [d_total_igv_soles_comprobante], [d_total_isc_soles_comprobante], [d_efectivo_soles_comprobante], [d_tipo_cambio_comprobante], [d_efectivo_dolares_comprobante], [d_pago_comprobante], [d_vuelto_comprobante], [v_monto_letras_comprobante], [v_hash_comprobante], [v_msjrpta_comprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (3, N'03', N'', N'', N'20100039207', N'12/07/2017', N'', N'0.00', N'O0001', N'c003', N'0.00', N'0.00      ', CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(16.9400 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)), CAST(3.2000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)), CAST(3.0600 AS Decimal(18, 4)), N'DIECISEIS CON 94/100', N'LYM/QlAFr3QeuNoR6dfoKyjcEBc=', NULL, 1, N'Jul 12 2017 10:02PM', NULL, NULL, N'1         ')
INSERT [dbo].[tb_comprobante] ([id_comprobante], [v_tipo_comprobante], [v_serie_comprobante], [v_numero_comprobante], [v_num_documento_cliente], [v_fecha_hora_comprobante], [v_placa_comprobante], [v_linea_cred_soles_comprobante], [v_cod_operador], [v_cod_turno], [v_tarjeta_soles_comprobante], [v_linea_cred_comprobante], [d_total_gravado_comprobante], [d_total_gratuito_comprobante], [d_total_inafecto_comprobante], [d_total_exonerado_comprobante], [d_dscnto_global_comprobante], [d_total_venta_soles_comprobante], [d_total_igv_soles_comprobante], [d_total_isc_soles_comprobante], [d_efectivo_soles_comprobante], [d_tipo_cambio_comprobante], [d_efectivo_dolares_comprobante], [d_pago_comprobante], [d_vuelto_comprobante], [v_monto_letras_comprobante], [v_hash_comprobante], [v_msjrpta_comprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (4, N'03', N'', N'', N'20100039207', N'12/07/2017', N'', N'0.00', N'O0001', N'c003', N'0.00', N'0.00      ', CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(30.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(30.0000 AS Decimal(18, 4)), CAST(3.2000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(30.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'TREINTA', N'cnAHzzT/gwcHnkcmZlI13QM+lfM=', NULL, 1, N'Jul 12 2017 10:10PM', NULL, NULL, N'1         ')
SET IDENTITY_INSERT [dbo].[tb_comprobante] OFF
INSERT [dbo].[tb_comprobante_detalle] ([id_comprobante], [id_item_comprobante], [v_cod_isla], [v_cod_surtidor], [v_cod_lados], [v_cod_manguera], [v_cod_producto], [d_precio_unitario_dcomprobante], [d_cantidad_dcomprobante], [d_subtotal_gravado_comprobante], [d_subtotal_gratuito_comprobante], [d_subtotal_inafecto_comprobante], [d_subtotal_exonerado_comprobante], [d_subtotal_item_comprobante], [i_flg_afecto_igv], [d_igv_item_dcomprobante], [i_flg_afecto_isc], [d_isc_item_dcomprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, 0, N'c001', N'c0002', N'c003', N'M0001', N'c003', CAST(8.4700 AS Decimal(18, 4)), CAST(1.0000 AS Decimal(18, 4)), CAST(8.4700 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(8.4700 AS Decimal(18, 4)), 1, CAST(1.5300 AS Decimal(18, 4)), 1, CAST(0.8500 AS Decimal(18, 4)), 1, N'Jul 12 2017 12:43PM', NULL, NULL, 1)
INSERT [dbo].[tb_comprobante_detalle] ([id_comprobante], [id_item_comprobante], [v_cod_isla], [v_cod_surtidor], [v_cod_lados], [v_cod_manguera], [v_cod_producto], [d_precio_unitario_dcomprobante], [d_cantidad_dcomprobante], [d_subtotal_gravado_comprobante], [d_subtotal_gratuito_comprobante], [d_subtotal_inafecto_comprobante], [d_subtotal_exonerado_comprobante], [d_subtotal_item_comprobante], [i_flg_afecto_igv], [d_igv_item_dcomprobante], [i_flg_afecto_isc], [d_isc_item_dcomprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, 0, N'c001', N'c0002', N'c003', N'M0001', N'c003', CAST(8.4700 AS Decimal(18, 4)), CAST(4.0000 AS Decimal(18, 4)), CAST(8.4700 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(33.8800 AS Decimal(18, 4)), 1, CAST(1.5300 AS Decimal(18, 4)), 1, CAST(0.8500 AS Decimal(18, 4)), 1, N'Jul 12 2017  9:48PM', NULL, NULL, 1)
INSERT [dbo].[tb_comprobante_detalle] ([id_comprobante], [id_item_comprobante], [v_cod_isla], [v_cod_surtidor], [v_cod_lados], [v_cod_manguera], [v_cod_producto], [d_precio_unitario_dcomprobante], [d_cantidad_dcomprobante], [d_subtotal_gravado_comprobante], [d_subtotal_gratuito_comprobante], [d_subtotal_inafecto_comprobante], [d_subtotal_exonerado_comprobante], [d_subtotal_item_comprobante], [i_flg_afecto_igv], [d_igv_item_dcomprobante], [i_flg_afecto_isc], [d_isc_item_dcomprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (3, 0, N'c001', N'c0002', N'c003', N'M0001', N'c003', CAST(8.4700 AS Decimal(18, 4)), CAST(2.0000 AS Decimal(18, 4)), CAST(8.4700 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(16.9400 AS Decimal(18, 4)), 1, CAST(1.5300 AS Decimal(18, 4)), 1, CAST(0.8500 AS Decimal(18, 4)), 1, N'Jul 12 2017 10:02PM', NULL, NULL, 1)
INSERT [dbo].[tb_comprobante_detalle] ([id_comprobante], [id_item_comprobante], [v_cod_isla], [v_cod_surtidor], [v_cod_lados], [v_cod_manguera], [v_cod_producto], [d_precio_unitario_dcomprobante], [d_cantidad_dcomprobante], [d_subtotal_gravado_comprobante], [d_subtotal_gratuito_comprobante], [d_subtotal_inafecto_comprobante], [d_subtotal_exonerado_comprobante], [d_subtotal_item_comprobante], [i_flg_afecto_igv], [d_igv_item_dcomprobante], [i_flg_afecto_isc], [d_isc_item_dcomprobante], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (4, 0, N'c001', N'c0002', N'c003', N'M0001', N'c003', CAST(15.0000 AS Decimal(18, 4)), CAST(2.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(15.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(30.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)), 0, CAST(0.0000 AS Decimal(18, 4)), 1, N'Jul 12 2017 10:10PM', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_departamento] ON 

INSERT [dbo].[tb_departamento] ([id_departamento], [v_desc_departamento], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'Lima', 1, N'08/06/2017', NULL, NULL, 1)
INSERT [dbo].[tb_departamento] ([id_departamento], [v_desc_departamento], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, N'Junin', 2, N'08/06/2017', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_departamento] OFF
SET IDENTITY_INSERT [dbo].[tb_distrito] ON 

INSERT [dbo].[tb_distrito] ([id_distrito], [id_provincia], [v_desc_distrito], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, 1, N'SJL', 1, N'08/06/2017', NULL, NULL, 1)
INSERT [dbo].[tb_distrito] ([id_distrito], [id_provincia], [v_desc_distrito], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, 2, N'Mantarana', 2, N'08/06/2017', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_distrito] OFF
SET IDENTITY_INSERT [dbo].[tb_documentos] ON 

INSERT [dbo].[tb_documentos] ([id_documento], [v_cod_documento], [v_deno_documento], [v_serie_documento], [v_num_documento], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (69, N'C003', N'director', N'123d', N'322343', 1, N'Jul  3 2017 12:35PM', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_documentos] OFF
SET IDENTITY_INSERT [dbo].[tb_empresa] ON 

INSERT [dbo].[tb_empresa] ([id_empresa], [v_num_documento], [v_nom_empresa], [v_direccion_empresa], [id_departamento], [id_provincia], [id_distrito], [v_ubigeo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_texto]) VALUES (13, N'3432134223', N'transpote kenny', N'jr.los incas 433', 1, 1, 1, N'dwedwe', 1, N'Jul  3 2017 12:39PM', NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[tb_empresa] OFF
INSERT [dbo].[tb_empresa_calcimp] ([id_empresa], [id_calcimp], [d_calculoIGV_calcimp], [d_calculoISC_calcimp], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (13, 1, CAST(0.1800 AS Decimal(18, 4)), CAST(0.1000 AS Decimal(18, 4)), 1, N'2017-07-11', 1, N'2017-07-11', 1)
SET IDENTITY_INSERT [dbo].[tb_islas] ON 

INSERT [dbo].[tb_islas] ([id_isla], [v_cod_isla], [v_denominacion_isla], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (9, N'c001', N'irac', 1, N'Jul  3 2017 12:39PM', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_islas] OFF
SET IDENTITY_INSERT [dbo].[tb_lados] ON 

INSERT [dbo].[tb_lados] ([id_lados], [v_cod_lados], [v_denominacion_lados], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (15, N'c003', N'LAteral izquierdo', 1, N'Jul  3 2017 12:38PM', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_lados] OFF
SET IDENTITY_INSERT [dbo].[tb_mangueras] ON 

INSERT [dbo].[tb_mangueras] ([id_manguera], [v_cod_manguera], [v_denominacion_manguera], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'M0001', N'Manguera 1', 1, N'2017-07-10', 1, N'2017-07-10', 1)
SET IDENTITY_INSERT [dbo].[tb_mangueras] OFF
SET IDENTITY_INSERT [dbo].[tb_nivel] ON 

INSERT [dbo].[tb_nivel] ([id_nivel], [v_desc_nivel], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'Ventas', 1, N'14/062017', 1, N'', 1)
INSERT [dbo].[tb_nivel] ([id_nivel], [v_desc_nivel], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, N'Supervición', 1, N'14/062017', 1, N'', 1)
INSERT [dbo].[tb_nivel] ([id_nivel], [v_desc_nivel], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (3, N'Administrativos', 1, N'14/062017', 1, N'', 1)
SET IDENTITY_INSERT [dbo].[tb_nivel] OFF
SET IDENTITY_INSERT [dbo].[tb_nivel_dcto_cliente] ON 

INSERT [dbo].[tb_nivel_dcto_cliente] ([id_nivel_dto_cliente], [id_cliente], [id_producto], [d_cant_minima], [d_dto_cantidad], [i_estado_registro]) VALUES (3, 2, 1, CAST(1243 AS Decimal(18, 0)), CAST(1245 AS Decimal(18, 0)), 1)
INSERT [dbo].[tb_nivel_dcto_cliente] ([id_nivel_dto_cliente], [id_cliente], [id_producto], [d_cant_minima], [d_dto_cantidad], [i_estado_registro]) VALUES (4, 22, 43, CAST(1245 AS Decimal(18, 0)), CAST(1248 AS Decimal(18, 0)), 1)
INSERT [dbo].[tb_nivel_dcto_cliente] ([id_nivel_dto_cliente], [id_cliente], [id_producto], [d_cant_minima], [d_dto_cantidad], [i_estado_registro]) VALUES (5, 26, 44, CAST(1489 AS Decimal(18, 0)), CAST(1367 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[tb_nivel_dcto_cliente] OFF
SET IDENTITY_INSERT [dbo].[tb_operador] ON 

INSERT [dbo].[tb_operador] ([id_operador], [v_cod_operador], [v_nombre_operador], [v_apepaterno_operador], [v_apematerno_operador], [id_nivel], [v_usuario_operador], [v_clave_operador], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'O0001', N'Julio', N'Avila', N'Bastidas', 1, N'javila', N'123456', 1, N'2017-07-11', 1, N'2017-07-11', 1)
SET IDENTITY_INSERT [dbo].[tb_operador] OFF
SET IDENTITY_INSERT [dbo].[tb_operador_usuario] ON 

INSERT [dbo].[tb_operador_usuario] ([id_operador_usuario], [v_cod_operador_usuario], [v_nombre_operador_usuario], [id_nivel], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_clave_operador_usuario]) VALUES (35, N'C002', N'bradley', 3, 1, N'Jul  3 2017 12:36PM', NULL, NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[tb_operador_usuario] OFF
SET IDENTITY_INSERT [dbo].[tb_producto] ON 

INSERT [dbo].[tb_producto] ([id_producto], [v_cod_producto], [v_nom_producto], [d_p_venta], [d_c_compra], [i_flg_afecto_igv], [i_flg_afecto_isc], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_uni_med]) VALUES (1, N'P001', N'GLP', CAST(10.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), 1, 1, 1, N'2017-07-11', 1, N'2017-07-11', 1, N'GLL')
INSERT [dbo].[tb_producto] ([id_producto], [v_cod_producto], [v_nom_producto], [d_p_venta], [d_c_compra], [i_flg_afecto_igv], [i_flg_afecto_isc], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_uni_med]) VALUES (2, N'P002', N'GNV', CAST(15.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), 0, 0, 1, N'2017-''07.-11', 1, N'2017-07-11', 1, N'GLL')
SET IDENTITY_INSERT [dbo].[tb_producto] OFF
SET IDENTITY_INSERT [dbo].[tb_provincia] ON 

INSERT [dbo].[tb_provincia] ([id_provincia], [id_departamento], [v_desc_provincia], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, 1, N'Lima', 1, N'08/06/2017', NULL, NULL, 1)
INSERT [dbo].[tb_provincia] ([id_provincia], [id_departamento], [v_desc_provincia], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, 2, N'Tarma', 2, N'08/06/2017', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_provincia] OFF
SET IDENTITY_INSERT [dbo].[tb_surtidor] ON 

INSERT [dbo].[tb_surtidor] ([id_surtidor], [v_cod_surtidor], [v_denominacion_surtidor], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (11, N'c0002', N'GLP', 1, N'Jul  3 2017 12:37PM', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_surtidor] OFF
SET IDENTITY_INSERT [dbo].[tb_tablas_tipo] ON 

INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'TB_TDE', NULL, N'TIPO DOCUMENTO AUTORIZADO PARA EFECTOS TRIBUTARIOS', 1, N'2017-07-10', 1, N'2017-07-10', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, N'TB_TDE', N'01', N'FACTURA', 1, N'2017-07-10', 1, N'2017-07-10', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (3, N'TB_TDE', N'03', N'BOLETA', 1, N'2017-07-10', 1, N'2017-07-10', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (4, N'TB_TDI', NULL, N'TIPO DOCUMENTO IDENTIFICACION', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (5, N'TB_TDI', N'0', N'DOC.TRIB.NO.DOM.SIN.RUC', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (6, N'TB_TDI', N'1', N'DOC. NACIONAL DE IDENTIDAD', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (7, N'TB_TDI', N'4', N'CARNET DE EXTRANJERIA', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (8, N'TB_TDI', N'6', N'REG. UNICO DE CONTRIBUYENTES', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (9, N'TB_TDI', N'7', N'PASAPORTE', 1, N'2017-07-11', 1, N'2017-07-11', 1)
INSERT [dbo].[tb_tablas_tipo] ([id_tabla_tipo], [v_cod_tabla_tipo], [v_item_tabla_tipo], [v_denominacion_tabla_tipo], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (10, N'TB_TDI', N'A', N'CED. DIPLOMATICA DE IDENTIDAD', 1, N'2017-07-11', 1, N'2017-07-11', 1)
SET IDENTITY_INSERT [dbo].[tb_tablas_tipo] OFF
SET IDENTITY_INSERT [dbo].[tb_tcambio] ON 

INSERT [dbo].[tb_tcambio] ([id_tcambio], [v_fecha], [d_venta], [d_compra], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (40, N'2017-07-03', CAST(3.60 AS Decimal(18, 2)), CAST(3.50 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_tcambio] ([id_tcambio], [v_fecha], [d_venta], [d_compra], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (41, N'2017-07-11', CAST(3.20 AS Decimal(18, 2)), CAST(3.10 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tb_tcambio] ([id_tcambio], [v_fecha], [d_venta], [d_compra], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (42, N'2017-07-12', CAST(3.20 AS Decimal(18, 2)), CAST(3.10 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[tb_tcambio] OFF
SET IDENTITY_INSERT [dbo].[tb_tipo_documento] ON 

INSERT [dbo].[tb_tipo_documento] ([id_tipo_documento], [v_desc_tipo_documento], [v_abrev_tipo_documento], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (1, N'Documento Nacional de Identidad', N'DNI', 1, N'08/06/2017', NULL, NULL, 1)
INSERT [dbo].[tb_tipo_documento] ([id_tipo_documento], [v_desc_tipo_documento], [v_abrev_tipo_documento], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro]) VALUES (2, N'Registro Único de Contribuyentes', N'RUC', 2, N'08/06/2017', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[tb_tipo_documento] OFF
SET IDENTITY_INSERT [dbo].[tb_Tipo_Perfil] ON 

INSERT [dbo].[tb_Tipo_Perfil] ([id_tipo_perfil], [Tipo_perfil], [id_registro]) VALUES (1, N'Admin', 1)
INSERT [dbo].[tb_Tipo_Perfil] ([id_tipo_perfil], [Tipo_perfil], [id_registro]) VALUES (2, N'Usuario', 1)
SET IDENTITY_INSERT [dbo].[tb_Tipo_Perfil] OFF
SET IDENTITY_INSERT [dbo].[tb_turnos] ON 

INSERT [dbo].[tb_turnos] ([id_turno], [v_cod_turno], [v_denominacion_turno], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_hora_inicio], [v_hora_fin]) VALUES (24, N'c002', N'MAÑANA', 1, N'2017-07-11', 1, N'2017-07-11', 1, N'06:00:00', N'12:00:00')
INSERT [dbo].[tb_turnos] ([id_turno], [v_cod_turno], [v_denominacion_turno], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_hora_inicio], [v_hora_fin]) VALUES (25, N'c003', N'TARDE', 1, N'2017-07-11', 1, N'2017-07-11', 1, N'12:00:00', N'19:00:00')
INSERT [dbo].[tb_turnos] ([id_turno], [v_cod_turno], [v_denominacion_turno], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_hora_inicio], [v_hora_fin]) VALUES (26, N'c003', N'NOCHE', 1, N'2017-07-11', 1, N'2017-07-11', 1, N'19:00:00', N'23:59:00')
INSERT [dbo].[tb_turnos] ([id_turno], [v_cod_turno], [v_denominacion_turno], [id_usuario_creacion], [v_fecha_creacion], [id_usuario_modificacion], [v_fecha_modificacion], [i_estado_registro], [v_hora_inicio], [v_hora_fin]) VALUES (27, N'c004', N'MADRUGADA', 1, N'2017-07-11', 1, N'2017-07-11', 1, N'00:00:00', N'06:00:00')
SET IDENTITY_INSERT [dbo].[tb_turnos] OFF
SET IDENTITY_INSERT [dbo].[tb_Usuarios] ON 

INSERT [dbo].[tb_Usuarios] ([id_usuario], [v_nom_usuario], [v_usuario], [v_clave_usuario], [i_estado_registro], [id_tipo_perfil]) VALUES (8, N'bradley', N'raul', N'1234', 1, 1)
INSERT [dbo].[tb_Usuarios] ([id_usuario], [v_nom_usuario], [v_usuario], [v_clave_usuario], [i_estado_registro], [id_tipo_perfil]) VALUES (9, N'julio', N'julio', N'ambar', 1, 1)
SET IDENTITY_INSERT [dbo].[tb_Usuarios] OFF
ALTER TABLE [dbo].[tb_Usuarios]  WITH CHECK ADD FOREIGN KEY([id_tipo_perfil])
REFERENCES [dbo].[tb_Tipo_Perfil] ([id_tipo_perfil])
GO
ALTER TABLE [dbo].[VENDEDORES]  WITH CHECK ADD FOREIGN KEY([DNI_US])
REFERENCES [dbo].[usuarios] ([DNI_US])
GO
ALTER TABLE [dbo].[VENTAS_REALIZADAS]  WITH CHECK ADD FOREIGN KEY([CODIGO_PRO])
REFERENCES [dbo].[PRODUCTO] ([CODIGO_PRO])
GO
ALTER TABLE [dbo].[VENTAS_REALIZADAS]  WITH CHECK ADD FOREIGN KEY([DNI_CLIE])
REFERENCES [dbo].[CLIENTES] ([DNI_CLIE])
GO
ALTER TABLE [dbo].[VENTAS_REALIZADAS]  WITH CHECK ADD FOREIGN KEY([DNI_US])
REFERENCES [dbo].[VENDEDORES] ([DNI_US])
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_PRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
   create procedure [dbo].[ELIMINAR_PRODUCTO]
  @CODIGO_PRO int
   as
   delete from PRODUCTO where CODIGO_PRO=@CODIGO_PRO
   return

GO
/****** Object:  StoredProcedure [dbo].[lista_vendedores]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[lista_vendedores]
	As
	Select DNI_US from VENDEDORES
	return

/*Procedimiento para registrar vendedores*/
if object_id('p_Registro_vendedores') is Not null
	drop procedure p_Registro_vendedores

GO
/****** Object:  StoredProcedure [dbo].[LISTAR_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[LISTAR_CLIENTES]
	As
	Select * from CLIENTES
	return



if object_id('lista_vendedores') is Not null
	drop procedure lista_vendedores

GO
/****** Object:  StoredProcedure [dbo].[LISTAR_PRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[LISTAR_PRODUCTO]
	As
	Select * from PRODUCTO
	return

	--ELIMINAR PRODUCTO
	if object_id('ELIMINAR_PRODUCTO') is not null
   drop procedure ELIMINAR_PRODUCTO

GO
/****** Object:  StoredProcedure [dbo].[LISTAR_PRODUCTO_VENDEDORES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[LISTAR_PRODUCTO_VENDEDORES]
	As
	Select * from VENDEDORES
	return


/*Procedimiento para guardar VENTAS_REALIZADAS*/
if object_id('p_REGISTRAR_VENTAS_REALIZADAS') is Not null
	drop procedure p_REGISTRAR_VENTAS_REALIZADAS

GO
/****** Object:  StoredProcedure [dbo].[LISTAR_VENTAS_REALIZADAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[LISTAR_VENTAS_REALIZADAS]
	As
	Select * from VENTAS_REALIZADAS
	return
	Select * from VENTAS_REALIZADAS

	--------------------------------------------------------------------------------------------

--listar usuarios
if object_id('LISTAUSUARIOS') is Not null
	drop procedure LISTAUSUARIOS

GO
/****** Object:  StoredProcedure [dbo].[LISTAUSUARIOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[LISTAUSUARIOS]
	As
	Select * from usuarios
	return
	Select * from usuarios

	--listar usuarios
if object_id('usuarioslistado') is Not null
	drop procedure usuarioslistado

GO
/****** Object:  StoredProcedure [dbo].[p_actualizar_producto]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_actualizar_producto]
	@CODIGO_PRO int  ,
	@NOMBRE varchar(50) ,
	@MARCA  varchar(50) ,
	@DESCRIPCION VARCHAR (50)  ,
	@PRECIO MONEY ,
	@CANTIDAD INT 
	as
	Update PRODUCTO 
	set	NOMBRE=@NOMBRE,
		MARCA=@MARCA,
		DESCRIPCION=@DESCRIPCION,
		PRECIO = @PRECIO,
		CANTIDAD = @CANTIDAD
	where CODIGO_PRO=@CODIGO_PRO

	return


	/*PROCEDIMEINTO PARA LISTAR PRODUCTO*/
if object_id('LISTAR_PRODUCTO') is Not null
	drop procedure LISTAR_PRODUCTO

GO
/****** Object:  StoredProcedure [dbo].[p_REGISTRAR_usuarios]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_REGISTRAR_usuarios]
 @DNI_US CHAR (8),
 @USUARIO VARCHAR (20),
  @PASSWOR VARCHAR (20),
  @CATEGORIA VARCHAR (30)
	as
	Insert usuarios 
	values (@DNI_US,@USUARIO,@PASSWOR,@CATEGORIA)
	return

GO
/****** Object:  StoredProcedure [dbo].[p_REGISTRAR_VENTAS_REALIZADAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_REGISTRAR_VENTAS_REALIZADAS]
  @DNI_CLIE CHAR (8),
  @NOMBRE_CLI varchar(50) ,
  @CODIGO_PRO int,
  @TOTAL MONEY,
  @DNI_US char (8),
  @FECHA DATE,
  @CANCELADO BIT
	as
	Insert VENTAS_REALIZADAS values (@DNI_CLIE,@NOMBRE_CLI,@CODIGO_PRO, @TOTAL,@DNI_US,@FECHA,@CANCELADO)
	return

GO
/****** Object:  StoredProcedure [dbo].[p_Registro_clientes]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_Registro_clientes]
	     @DNI_CLIE CHAR (8) ,
  @NOMBRE varchar(50) ,
  @DIRECCION  varchar(50)
		 
	as
	Insert CLIENTES 
	values (@DNI_CLIE,@NOMBRE,@DIRECCION)
	return

GO
/****** Object:  StoredProcedure [dbo].[p_Registro_producto]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_Registro_producto]
	@NOMBRE varchar(50) ,
	@MARCA  varchar(50) ,
	@DESCRIPCION VARCHAR (50)  ,
	@PRECIO MONEY ,
	@CANTIDAD INT 
	as
	Insert PRODUCTO 
	values (@NOMBRE,@MARCA,
	@DESCRIPCION, @PRECIO, @CANTIDAD)
	return

GO
/****** Object:  StoredProcedure [dbo].[p_Registro_vendedores]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[p_Registro_vendedores]
  @DNI CHAR (8) ,
  @NOMBRE varchar(80) ,
  @DIRECCION  varchar(50),
  @TELEFONO CHAR (13),
  @TURNO VARCHAR (30),
  @SEXO CHAR (1) 
	as
	Insert VENDEDORES 
	values (@DNI,@NOMBRE,
	@DIRECCION, @TELEFONO, @TURNO, @SEXO)
	return

GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZAUSUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ACTUALIZAUSUARIO]
(
@DNI_US CHAR (8),
 @USUARIO VARCHAR (20),
  @PASSWOR VARCHAR (20),
  @CATEGORIA VARCHAR (30)
)
AS
UPDATE usuarios
SET USUARIO=@USUARIO,
PASSWOR=@PASSWOR,
CATEGORIA=@CATEGORIA
WHERE DNI_US=@DNI_US

GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAUCLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCAUCLIENTES](@DNI_CLIE CHAR (8))
AS
SELECT * FROM CLIENTES
WHERE DNI_CLIE=@DNI_CLIE

GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAUPRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCAUPRODUCTO](@CODIGO_PRO int)
AS
SELECT * FROM PRODUCTO
WHERE CODIGO_PRO=@CODIGO_PRO

GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCAUSUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BUSCAUSUARIO](@DNI_US CHAR (8))
AS
SELECT * FROM usuarios
WHERE DNI_US=@DNI_US

GO
/****** Object:  StoredProcedure [dbo].[USP_DEL_TIPO_CAMBIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_DEL_TIPO_CAMBIO]
	@id_tcambio INT
AS
BEGIN
	DELETE FROM tb_tcambio WHERE id_tcambio=@id_tcambio;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_CLIENTES]
	@id_cliente INT OUTPUT,
	@id_tipo_documento INT,
	@v_num_documento VARCHAR(11),
	@v_nom_cliente VARCHAR(50),
	@v_direccion_cliente VARCHAR(100),
	@id_departamento INT,
	@id_provincia INT,
	@id_distrito INT,
	@v_ubigeo INT,
	@i_chk_promo_vigentes INT,
	@i_chk_aceptar_vtas_credito INT,
	@d_linea_credito DECIMAL(18,2),
	@d_credito_utilizado DECIMAL(18,2),
	@d_credito_disponible DECIMAL(18,2),
	@id_usuario_creacion INT
	
	



AS
BEGIN
	INSERT INTO tb_cliente
		(id_tipo_documento, 
	v_num_documento,
	v_nom_cliente,
	v_direccion_cliente,
	id_departamento,
	id_provincia,
	id_distrito,
	v_ubigeo,
	i_chk_promo_vigentes,
	i_chk_aceptar_vtas_credito,
	d_linea_credito,
	d_credito_utilizado,
	d_credito_disponible,
	id_usuario_creacion,		
	v_fecha_creacion,
	i_estado_registro)

	VALUES
		(@id_tipo_documento,
		@v_num_documento,
		@v_nom_cliente,
		@v_direccion_cliente,
		@id_departamento,
		@id_provincia,
		@id_distrito,
		@v_ubigeo,
		@i_chk_promo_vigentes,
		@i_chk_aceptar_vtas_credito,
		@d_linea_credito,
		@d_credito_utilizado,
		@d_credito_disponible,
		@id_usuario_creacion,
		GETDATE(),
		1);
	SELECT  @id_cliente = ISNULL(MAX(id_cliente),0) FROM tb_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_COMPROBANTE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_COMPROBANTE]
	@id_comprobante INT OUTPUT
	,@v_tipo_comprobante varchar(50)
    ,@v_serie_comprobante varchar(50)
    ,@v_numero_comprobante varchar(50)
    ,@v_num_documento_cliente varchar(11)
    ,@v_fecha_hora_comprobante varchar(50)
    ,@v_placa_comprobante varchar(50)
    ,@v_linea_cred_soles_comprobante varchar(50)
    ,@v_cod_operador varchar(50)
    ,@v_cod_turno varchar(50)
    ,@v_tarjeta_soles_comprobante varchar(50)
    ,@v_linea_cred_comprobante nchar(10)
    ,@d_total_gravado_comprobante decimal(18,4)
    ,@d_total_gratuito_comprobante decimal(18,4)
    ,@d_total_inafecto_comprobante decimal(18,4)
    ,@d_total_exonerado_comprobante decimal(18,4)
    ,@d_dscnto_global_comprobante decimal(18,4)
    ,@d_total_venta_soles_comprobante decimal(18,4)
    ,@d_total_igv_soles_comprobante decimal(18,4)
    ,@d_total_isc_soles_comprobante decimal(18,4)
    ,@d_efectivo_soles_comprobante decimal(18,4)
    ,@d_tipo_cambio_comprobante decimal(18,4)
    ,@d_efectivo_dolares_comprobante decimal(18,4)
    ,@d_pago_comprobante decimal(18,4)
    ,@d_vuelto_comprobante decimal(18,4)
    ,@v_monto_letras_comprobante varchar(100)
    ,@v_hash_comprobante varchar(200)
    ,@v_msjrpta_comprobante varchar(200)
    ,@id_usuario_creacion int
AS
BEGIN
	INSERT INTO [dbo].[tb_comprobante]
           ([v_tipo_comprobante]
           ,[v_serie_comprobante]
           ,[v_numero_comprobante]
           ,[v_num_documento_cliente]
           ,[v_fecha_hora_comprobante]
           ,[v_placa_comprobante]
           ,[v_linea_cred_soles_comprobante]
           ,[v_cod_operador]
           ,[v_cod_turno]
           ,[v_tarjeta_soles_comprobante]
           ,[v_linea_cred_comprobante]
           ,[d_total_gravado_comprobante]
           ,[d_total_gratuito_comprobante]
           ,[d_total_inafecto_comprobante]
           ,[d_total_exonerado_comprobante]
           ,[d_dscnto_global_comprobante]
           ,[d_total_venta_soles_comprobante]
           ,[d_total_igv_soles_comprobante]
           ,[d_total_isc_soles_comprobante]
           ,[d_efectivo_soles_comprobante]
           ,[d_tipo_cambio_comprobante]
           ,[d_efectivo_dolares_comprobante]
           ,[d_pago_comprobante]
           ,[d_vuelto_comprobante]
           ,[v_monto_letras_comprobante]
           ,[v_hash_comprobante]
           ,[v_msjrpta_comprobante]
           ,[id_usuario_creacion]
           ,[v_fecha_creacion]
           ,[i_estado_registro])
     VALUES
           (@v_tipo_comprobante
			,@v_serie_comprobante
			,@v_numero_comprobante
			,@v_num_documento_cliente
			,@v_fecha_hora_comprobante
			,@v_placa_comprobante
			,@v_linea_cred_soles_comprobante
			,@v_cod_operador
			,@v_cod_turno
			,@v_tarjeta_soles_comprobante
			,@v_linea_cred_comprobante
			,@d_total_gravado_comprobante
			,@d_total_gratuito_comprobante
			,@d_total_inafecto_comprobante
			,@d_total_exonerado_comprobante
			,@d_dscnto_global_comprobante
			,@d_total_venta_soles_comprobante
			,@d_total_igv_soles_comprobante
			,@d_total_isc_soles_comprobante
			,@d_efectivo_soles_comprobante
			,@d_tipo_cambio_comprobante
			,@d_efectivo_dolares_comprobante
			,@d_pago_comprobante
			,@d_vuelto_comprobante
			,@v_monto_letras_comprobante
			,@v_hash_comprobante
			,@v_msjrpta_comprobante
			,@id_usuario_creacion
			,GETDATE()
			,1)

	SELECT  @id_comprobante = ISNULL(MAX(id_comprobante),0) FROM tb_comprobante;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_COMPROBANTE_DETALLE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_COMPROBANTE_DETALLE]
	@id_item_comprobante int OUTPUT
	,@id_comprobante int
    ,@v_cod_isla varchar(50)
    ,@v_cod_surtidor varchar(50)
    ,@v_cod_lados varchar(50)
    ,@v_cod_manguera varchar(50)
    ,@v_cod_producto varchar(20)
    ,@d_precio_unitario_dcomprobante decimal(18,4)
    ,@d_cantidad_dcomprobante decimal(18,4)
    ,@d_subtotal_gravado_comprobante decimal(18,4)
    ,@d_subtotal_gratuito_comprobante decimal(18,4)
    ,@d_subtotal_inafecto_comprobante decimal(18,4)
    ,@d_subtotal_exonerado_comprobante decimal(18,4)
    ,@d_subtotal_item_comprobante decimal(18,4)
    ,@i_flg_afecto_igv int
    ,@d_igv_item_dcomprobante decimal(18,4)
    ,@i_flg_afecto_isc int
    ,@d_isc_item_dcomprobante decimal(18,4)
    ,@id_usuario_creacion int
AS
BEGIN
	DECLARE @N_ID_ITEM_COMPROBANTE INT

	SELECT @N_ID_ITEM_COMPROBANTE = ISNULL(MAX(ID_ITEM_COMPROBANTE), 0) FROM tb_comprobante_detalle WHERE id_comprobante = @id_comprobante

	INSERT INTO [dbo].[tb_comprobante_detalle]
           ([id_comprobante]
           ,[id_item_comprobante]
           ,[v_cod_isla]
           ,[v_cod_surtidor]
           ,[v_cod_lados]
           ,[v_cod_manguera]
           ,[v_cod_producto]
           ,[d_precio_unitario_dcomprobante]
           ,[d_cantidad_dcomprobante]
           ,[d_subtotal_gravado_comprobante]
           ,[d_subtotal_gratuito_comprobante]
           ,[d_subtotal_inafecto_comprobante]
           ,[d_subtotal_exonerado_comprobante]
           ,[d_subtotal_item_comprobante]
           ,[i_flg_afecto_igv]
           ,[d_igv_item_dcomprobante]
           ,[i_flg_afecto_isc]
           ,[d_isc_item_dcomprobante]
           ,[id_usuario_creacion]
           ,[v_fecha_creacion]
           ,[i_estado_registro])
     VALUES
           (@id_comprobante
           ,@N_ID_ITEM_COMPROBANTE
           ,@v_cod_isla
           ,@v_cod_surtidor
           ,@v_cod_lados
           ,@v_cod_manguera
           ,@v_cod_producto
           ,@d_precio_unitario_dcomprobante
           ,@d_cantidad_dcomprobante
           ,@d_subtotal_gravado_comprobante
           ,@d_subtotal_gratuito_comprobante
           ,@d_subtotal_inafecto_comprobante
           ,@d_subtotal_exonerado_comprobante
           ,@d_subtotal_item_comprobante
           ,@i_flg_afecto_igv
           ,@d_igv_item_dcomprobante
           ,@i_flg_afecto_isc
           ,@d_isc_item_dcomprobante
           ,@id_usuario_creacion
           ,GETDATE()
           ,1)

	SELECT  @id_item_comprobante = ISNULL(MAX(id_item_comprobante),0) FROM tb_comprobante_detalle WHERE id_comprobante = @id_comprobante;
END




GO
/****** Object:  StoredProcedure [dbo].[USP_INS_DESCUENTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_DESCUENTO]
	@id_nivel_dto_cliente INT OUTPUT,
	@id_cliente INT,
	@id_producto INT,
	@d_cant_minima DECIMAL(18,2),
	@d_dto_cantidad DECIMAL(18,2),
	@i_estado_registro INT
AS
BEGIN
	INSERT INTO tb_nivel_dto_cliente
		(id_cliente, 
	id_producto ,
	d_cant_minima ,
	d_dto_cantidad ,
	i_estado_registro)

	VALUES
		(@id_cliente,
		@id_producto,
		@d_cant_minima ,
		@d_dto_cantidad,
		1);
	SELECT  @id_nivel_dto_cliente = ISNULL(MAX(id_nivel_dto_cliente),0) FROM tb_nivel_dto_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_DOCUMENTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_DOCUMENTOS]
	@id_documento INT OUTPUT,
	@v_cod_documento VARCHAR(20),
	@v_deno_documento VARCHAR(50),
	@v_serie_documento VARCHAR(4),
	@v_num_documento VARCHAR(20),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_documentos
		(v_cod_documento,
		v_deno_documento,
		v_serie_documento,
		v_num_documento,
		id_usuario_creacion,		
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_documento,
		@v_deno_documento,
		@v_serie_documento,
		@v_num_documento,
		@id_usuario_creacion,
		GETDATE(),
		1);
	SELECT  @id_documento = ISNULL(MAX(id_documento),0) FROM tb_documentos;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_EMPRESA]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_INS_EMPRESA]
	@id_empresa INT OUTPUT,
	@v_num_documento VARCHAR(50),
	@v_nom_empresa VARCHAR(100),
	@v_direccion_empresa VARCHAR(200),
	@id_departamento INT,
	@id_provincia INT,
	@id_distrito INT,
	@v_ubigeo VARCHAR(50),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_empresa
		(v_num_documento,
		v_nom_empresa,
		v_direccion_empresa,
		id_departamento,
		id_provincia,
		id_distrito,
		v_ubigeo,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_num_documento,
		@v_nom_empresa,
		@v_direccion_empresa,
		@id_departamento,
		@id_provincia,
		@id_distrito,
		@v_ubigeo,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_empresa = ISNULL(MAX(id_empresa),0) FROM tb_empresa;	
END


GO
/****** Object:  StoredProcedure [dbo].[USP_INS_ISLAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ INS ================================
CREATE PROCEDURE [dbo].[USP_INS_ISLAS]
	@id_isla INT OUTPUT,
	@v_cod_isla VARCHAR(50),
	@v_denominacion_isla VARCHAR(50),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_islas
		(v_cod_isla,
		v_denominacion_isla,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_isla,
		@v_denominacion_isla,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_isla = ISNULL(MAX(id_isla),0) FROM tb_islas;	
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_LADOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_INS_LADOS]
	@id_lados INT OUTPUT,
	@v_cod_lados VARCHAR(50),
	@v_denominacion_lados VARCHAR(50),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_lados
		(v_cod_lados,
		v_denominacion_lados,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_lados,
		@v_denominacion_lados,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_lados = ISNULL(MAX(@id_lados),0) FROM tb_lados;	
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_NIVEL_DTO_CLIENTE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_INS_NIVEL_DTO_CLIENTE]
	@id_nivel_dto_cliente INT OUTPUT,
	@id_cliente INT,
	@id_producto INT,
	@d_cant_minima DECIMAL(18,2),
	@d_dto_cantidad DECIMAL(18,2)
AS
BEGIN
	INSERT INTO tb_nivel_dto_cliente
		(id_cliente,
		id_producto,
		d_cant_minima,
		d_dto_cantidad)
	VALUES
		(@id_cliente,
		@id_producto,
		@d_cant_minima,
		@d_dto_cantidad);
	SELECT  @id_nivel_dto_cliente = ISNULL(MAX(id_nivel_dto_cliente),0) FROM tb_nivel_dto_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_OPERADOR_USUARIOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_INS_OPERADOR_USUARIOS]
	@id_operador_usuario INT OUTPUT,
	@v_cod_operador_usuario VARCHAR(50),
	@v_nombre_operador_usuario VARCHAR(50),
	@id_nivel INT,
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_operador_usuario
		(
		v_cod_operador_usuario,
		v_nombre_operador_usuario,
		id_nivel,
		id_usuario_creacion,		
		v_fecha_creacion,
		i_estado_registro)

	VALUES
		(
	@v_cod_operador_usuario,
	@v_nombre_operador_usuario,
	@id_nivel,
		@id_usuario_creacion,
		GETDATE(),
		1);
	SELECT  @id_operador_usuario = ISNULL(MAX(id_operador_usuario ),0) FROM tb_operador_usuario;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_PRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ INS ================================


CREATE PROCEDURE [dbo].[USP_INS_PRODUCTO]
	@id_producto INT OUTPUT,
	@v_cod_producto VARCHAR(50),
	@v_nom_producto VARCHAR(50),
	@d_p_venta DECIMAL(18,2),
	@d_c_compra DECIMAL(18,2),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_producto
		(v_cod_producto,
		v_nom_producto,
		d_p_venta,
		d_c_compra,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_producto,
		@v_nom_producto,
		@d_p_venta,
		@d_c_compra,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_producto = ISNULL(MAX(id_producto),0) FROM tb_producto;	
END


GO
/****** Object:  StoredProcedure [dbo].[USP_INS_SURTIDOR]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ INS ================================
CREATE PROCEDURE [dbo].[USP_INS_SURTIDOR]
	@id_surtidor INT OUTPUT,
	@v_cod_surtidor VARCHAR(50),
	@v_denominacion_surtidor VARCHAR(50),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_surtidor
		(v_cod_surtidor,
		v_denominacion_surtidor,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_surtidor,
		@v_denominacion_surtidor,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_surtidor = ISNULL(MAX(id_surtidor),0) FROM tb_surtidor;	
END


GO
/****** Object:  StoredProcedure [dbo].[USP_INS_TIPO_CAMBIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_INS_TIPO_CAMBIO]
	@id_tcambio INT OUTPUT,
	@v_fecha VARCHAR(10),
	@d_venta DECIMAL(18,2),
	@d_compra DECIMAL(18,2)
AS
BEGIN
	INSERT INTO tb_tcambio
		(v_fecha,
		d_venta,
		d_compra)
	VALUES
		(@v_fecha,
		 @d_venta,
		 @d_compra);
	SELECT  @id_tcambio = ISNULL(MAX(id_tcambio),0) FROM tb_tcambio;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_TURNO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ INS ================================
CREATE PROCEDURE [dbo].[USP_INS_TURNO]
	@id_turno INT OUTPUT,
	@v_cod_turno VARCHAR(50),
	@v_denominacion_turno VARCHAR(50),
	@v_hora_inicio VARCHAR(08),
	@v_hora_fin VARCHAR(08),
	@id_usuario_creacion INT
AS
BEGIN
	INSERT INTO tb_turnos
		(v_cod_turno,
		v_denominacion_turno,
		v_hora_inicio,
		v_hora_fin ,
		id_usuario_creacion,
		v_fecha_creacion,
		i_estado_registro)
	VALUES
		(@v_cod_turno,
		@v_denominacion_turno,
		@v_hora_inicio,
		@v_hora_fin ,
		@id_usuario_creacion,
		GETDATE(),
		1);	
	SELECT @id_turno = ISNULL(MAX(id_turno),0) FROM tb_turnos;	
END

GO
/****** Object:  StoredProcedure [dbo].[USP_INS_USUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_INS_USUARIO]
	@id_usuario  INT OUTPUT,
	@v_nom_usuario  VARCHAR(20),       
	@v_usuario VARCHAR(20),
	@v_clave_usuario VARCHAR(20),
	@id_tipo_perfil INT
AS
BEGIN
	INSERT INTO tb_Usuarios
		(v_nom_usuario,
		v_usuario,
		v_clave_usuario,
		i_estado_registro,
		id_tipo_perfil)
	VALUES
		(@v_nom_usuario,       
		@v_usuario,
		@v_clave_usuario,
		1,
		@id_tipo_perfil);	
	SELECT @id_usuario = ISNULL(MAX(id_usuario),0) FROM tb_Usuarios;	
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_CLIENTES]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		CLIENTE.id_cliente,
		CLIENTE.id_tipo_documento,
		CLIENTE.v_num_documento,
		CLIENTE.v_nom_cliente,
		CLIENTE.v_direccion_cliente,
		CLIENTE.id_departamento,
		CLIENTE.id_provincia,
		CLIENTE.id_distrito,
		CLIENTE.v_ubigeo,
		CLIENTE.i_chk_promo_vigentes,
		CLIENTE.i_chk_aceptar_vtas_credito,
		CLIENTE.d_linea_credito,
		CLIENTE.d_credito_utilizado,
		CLIENTE.d_credito_disponible
	FROM
		tb_cliente CLIENTE
	WHERE
		CLIENTE.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR CLIENTE.v_num_documento LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR CLIENTE.v_nom_cliente LIKE '%' + @texto_buscar + '%' )
		)
	ORDER BY CLIENTE.v_nom_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_CLIENTES_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_CLIENTES_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		CLIENTE.id_cliente,
		ISNULL(CLIENTE.id_tipo_documento,0) AS id_tipo_documento,
		TDOCUMENTO.v_abrev_tipo_documento AS tipo_documento,
		CLIENTE.v_num_documento,
		CLIENTE.v_nom_cliente,
		CLIENTE.v_direccion_cliente,
		CLIENTE.id_departamento,
		DEPARTAMENTO.v_desc_departamento AS departamento,
		CLIENTE.id_provincia,
		PROVINCIA.v_desc_provincia AS provincia,
		CLIENTE.id_distrito,
		DISTRITO.v_desc_distrito AS distrito,
		CLIENTE.v_ubigeo,
		CLIENTE.i_chk_promo_vigentes,
		CLIENTE.i_chk_aceptar_vtas_credito,
		CLIENTE.d_linea_credito,
		CLIENTE.d_credito_utilizado,
		CLIENTE.d_credito_disponible
	FROM
		tb_cliente CLIENTE
	LEFT JOIN tb_tipo_documento TDOCUMENTO ON TDOCUMENTO.id_tipo_documento=CLIENTE.id_tipo_documento
	LEFT JOIN tb_departamento DEPARTAMENTO ON DEPARTAMENTO.id_departamento=CLIENTE.id_departamento
	LEFT JOIN tb_provincia PROVINCIA ON PROVINCIA.id_provincia=CLIENTE.id_provincia
	LEFT JOIN tb_distrito DISTRITO ON DISTRITO.id_distrito=CLIENTE.id_distrito
	WHERE
		id_cliente=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_CLIENTES_X_NUMDOC]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_CLIENTES_X_NUMDOC]
	@v_num_documento VARCHAR(11)
AS
BEGIN
	SELECT
		CLIENTE.id_cliente,
		CLIENTE.id_tipo_documento,
		CLIENTE.v_num_documento,
		CLIENTE.v_nom_cliente,
		CLIENTE.v_direccion_cliente,
		CLIENTE.id_departamento,
		CLIENTE.id_provincia,
		CLIENTE.id_distrito,
		CLIENTE.v_ubigeo,
		CLIENTE.i_chk_promo_vigentes,
		CLIENTE.i_chk_aceptar_vtas_credito,
		CLIENTE.d_linea_credito,
		CLIENTE.d_credito_utilizado,
		CLIENTE.d_credito_disponible
	FROM
		tb_cliente CLIENTE
	WHERE
		CLIENTE.i_estado_registro=1
		AND CLIENTE.v_num_documento = @v_num_documento
	ORDER BY CLIENTE.v_nom_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_DEPARTAMENTO_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_DEPARTAMENTO_DESP]

AS
BEGIN
	SELECT
		0 AS id_departamento,
		' -- SELECCIONE -- ' AS v_desc_departamento
	UNION ALL
	SELECT
		id_departamento,
		v_desc_departamento
	FROM
		tb_departamento
	WHERE
		i_estado_registro=1;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_DISTRITO_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_DISTRITO_DESP]
 @id_provincia INT
AS
BEGIN
	SELECT
		0 AS id_distrito,
		' -- SELECCIONE -- ' AS v_desc_distrito
	UNION ALL
	SELECT
		id_distrito,
		v_desc_distrito
	FROM
		tb_distrito
	WHERE
		i_estado_registro=1
		AND id_provincia=@id_provincia;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_DOCUMENTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_DOCUMENTOS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		DOCUMENTOS.id_documento,
		DOCUMENTOS.v_cod_documento,
		DOCUMENTOS.v_deno_documento,
		DOCUMENTOS.v_serie_documento,
		DOCUMENTOS.v_num_documento
	FROM
		tb_documentos DOCUMENTOS
	WHERE
		DOCUMENTOS.i_estado_registro=1
		
		AND ((@texto_buscar IS NULL OR DOCUMENTOS.v_serie_documento LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR DOCUMENTOS.v_deno_documento LIKE '%' + @texto_buscar + '%' )
		)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_DOCUMENTOS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_DOCUMENTOS_X_ID] 
	@ID INT
AS
BEGIN
	SELECT
		DOCUMENTOS.id_documento,
		DOCUMENTOS.v_cod_documento,
		DOCUMENTOS.v_deno_documento,
		DOCUMENTOS.v_serie_documento,
		DOCUMENTOS.v_num_documento
	FROM 
		tb_documentos DOCUMENTOS
	WHERE
		id_documento=@ID;

END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_EMPRESA]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_EMPRESA]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		EMPRESA.id_empresa,
		EMPRESA.v_num_documento,
		EMPRESA.v_nom_empresa,
		EMPRESA.v_direccion_empresa,
		DEPARTAMENTO.v_desc_departamento,
		PROVINCIA.v_desc_provincia,
		DISTRITO.v_desc_distrito,
		EMPRESA.v_ubigeo,
		EMPRESA.v_texto
	FROM
		tb_empresa EMPRESA
		LEFT JOIN tb_departamento DEPARTAMENTO ON DEPARTAMENTO.id_departamento=EMPRESA.id_departamento
		LEFT JOIN tb_provincia PROVINCIA ON PROVINCIA.id_provincia=EMPRESA.id_provincia
		LEFT JOIN tb_distrito DISTRITO ON DISTRITO.id_distrito=EMPRESA.id_provincia
	WHERE
		EMPRESA.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR EMPRESA.v_num_documento LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR EMPRESA.v_nom_empresa LIKE '%' + @texto_buscar + '%' ))
	ORDER BY EMPRESA.v_nom_empresa
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_EMPRESA_CALCIMP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_EMPRESA_CALCIMP]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		EMPRESA_CALCIMP.id_empresa,
		EMPRESA_CALCIMP.id_calcimp,
		EMPRESA_CALCIMP.d_calculoIGV_calcimp,
		EMPRESA_CALCIMP.d_calculoISC_calcimp
	FROM
		tb_empresa_calc_imp EMPRESA_CALCIMP
	WHERE
		EMPRESA_CALCIMP.i_estado_registro=1
	ORDER BY EMPRESA_CALCIMP.id_empresa, EMPRESA_CALCIMP.id_calcimp
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_EMPRESA_CALCIMP_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_EMPRESA_CALCIMP_X_ID]
	@ID_empresa INT,
	@ID_calcimp INT
AS
BEGIN
	SELECT
		EMPRESA_CALCIMP.id_empresa,
		EMPRESA_CALCIMP.id_calcimp,
		EMPRESA_CALCIMP.d_calculoIGV_calcimp,
		EMPRESA_CALCIMP.d_calculoISC_calcimp
	FROM
		tb_empresa_calcimp EMPRESA_CALCIMP
	WHERE
		id_empresa=@ID_empresa AND id_calcimp = @ID_calcimp
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_EMPRESA_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_EMPRESA_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		EMPRESA.id_empresa,
		EMPRESA.v_num_documento,
		EMPRESA.v_nom_empresa,
		EMPRESA.v_direccion_empresa,
		EMPRESA.id_departamento,
		DEPARTAMENTO.v_desc_departamento,
		EMPRESA.id_provincia,
		PROVINCIA.v_desc_provincia,
		EMPRESA.id_distrito,
		DISTRITO.v_desc_distrito,
		EMPRESA.v_ubigeo,
		EMPRESA.v_texto
	FROM
		tb_empresa EMPRESA
		LEFT JOIN tb_departamento DEPARTAMENTO ON DEPARTAMENTO.id_departamento=EMPRESA.id_departamento
		LEFT JOIN tb_provincia PROVINCIA ON PROVINCIA.id_provincia=EMPRESA.id_provincia
		LEFT JOIN tb_distrito DISTRITO ON DISTRITO.id_distrito=EMPRESA.id_provincia

	WHERE
		id_empresa=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_ISLAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_ISLAS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		ISLAS.id_isla,
		ISLAS.v_cod_isla,
		ISLAS.v_denominacion_isla
	
	FROM
		tb_islas ISLAS
	WHERE
		ISLAS.i_estado_registro=1
		AND (@texto_buscar IS NULL OR ISLAS.v_denominacion_isla LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR ISLAS.v_cod_isla LIKE '%' + @texto_buscar + '%' )
	ORDER BY ISLAS.v_denominacion_isla
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_ISLAS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_ISLAS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		ISLAS.id_isla,
		ISLAS.v_cod_isla,
		ISLAS.v_denominacion_isla
		
	FROM
		tb_islas ISLAS
	WHERE
		id_isla=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_LADOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_LADOS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		LADOS.id_lados,
		LADOS.v_cod_lados,
		LADOS.v_denominacion_lados
	FROM
		tb_lados LADOS
	WHERE
		LADOS.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR LADOS.v_cod_lados LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR LADOS.v_denominacion_lados LIKE '%' + @texto_buscar + '%' ))
	ORDER BY LADOS.v_denominacion_lados
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_LADOS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_LADOS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		LADOS.id_lados,
		LADOS.v_cod_lados,
		LADOS.v_denominacion_lados
	FROM
		tb_lados LADOS
	WHERE
		id_lados=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_MANGUERAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_MANGUERAS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		MANGUERAS.id_manguera,
		MANGUERAS.v_cod_manguera,
		MANGUERAS.v_denominacion_manguera
	
	FROM
		tb_mangueras MANGUERAS
	WHERE
		MANGUERAS.i_estado_registro=1
		AND (@texto_buscar IS NULL OR MANGUERAS.v_denominacion_manguera LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR MANGUERAS.v_cod_manguera LIKE '%' + @texto_buscar + '%' )
	ORDER BY MANGUERAS.v_denominacion_manguera
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_MANGUERAS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_MANGUERAS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		MANGUERAS.id_manguera,
		MANGUERAS.v_cod_manguera,
		MANGUERAS.v_denominacion_manguera
		
	FROM
		tb_mangueras MANGUERAS
	WHERE
		id_manguera=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_NIVEL]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_NIVEL]
AS
BEGIN
SELECT
		0 AS id_nivel,
		' -- SELECCIONE -- ' AS v_desc_nivel
	UNION ALL
	
	SELECT
		id_nivel,
		v_desc_nivel
	FROM
		tb_nivel 
		WHERE
		i_estado_registro=1;
	
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_NIVEL_DCTO_X_CLIENTE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_NIVEL_DCTO_X_CLIENTE]
	@id_cliente INT
AS
BEGIN
	SELECT
		DCTOCLIENTE.id_nivel_dto_cliente,
		DCTOCLIENTE.id_cliente,
		DCTOCLIENTE.id_producto,
		PRODUCTO.v_nom_producto,
		DCTOCLIENTE.d_cant_minima,
		DCTOCLIENTE.d_dto_cantidad
	FROM
		tb_nivel_dcto_cliente DCTOCLIENTE
	LEFT JOIN tb_producto PRODUCTO ON PRODUCTO.id_producto=DCTOCLIENTE.id_producto
	WHERE
		DCTOCLIENTE.id_cliente=@id_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_NIVEL_DTO_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_NIVEL_DTO_CLIENTES]
AS
BEGIN
	SELECT
		DESCUENTO.id_nivel_dto_cliente,
		DESCUENTO.id_producto,
		DESCUENTO.d_cant_minima,
		DESCUENTO.d_dto_cantidad
	FROM
		tb_nivel_dto_cliente DESCUENTO
	ORDER BY DESCUENTO.id_nivel_dto_cliente DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_OPERADOR]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_OPERADOR]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		OPERADOR.id_operador,
		OPERADOR.v_cod_operador,
		OPERADOR.v_nombre_operador,
		OPERADOR.v_apepaterno_operador,
		OPERADOR.v_apematerno_operador,
		OPERADOR.id_nivel,
		OPERADOR.v_usuario_operador,
		OPERADOR.v_clave_operador
	FROM
		tb_operador OPERADOR
	WHERE
		OPERADOR.i_estado_registro=1
	ORDER BY OPERADOR.v_cod_operador
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_OPERADOR_LOGUEO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_OPERADOR_LOGUEO]
	@v_usuario_operador VARCHAR(20),
	@v_clave_operador VARCHAR(20)
AS
BEGIN
	SELECT
		OPERADOR.id_operador,
		OPERADOR.v_cod_operador,
		OPERADOR.v_nombre_operador,
		OPERADOR.v_apepaterno_operador,
		OPERADOR.v_apematerno_operador,
		OPERADOR.id_nivel,
		OPERADOR.v_usuario_operador,
		OPERADOR.v_clave_operador
	FROM
		tb_operador OPERADOR
	WHERE
		OPERADOR.i_estado_registro=1 
		AND OPERADOR.v_usuario_operador = @v_usuario_operador
		AND OPERADOR.v_clave_operador = @v_clave_operador
	ORDER BY OPERADOR.v_cod_operador
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_OPERADOR_USUARIOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_OPERADOR_USUARIOS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		OPERADOR_USUARIO.id_operador_usuario,
		OPERADOR_USUARIO.v_cod_operador_usuario,
		OPERADOR_USUARIO.v_nombre_operador_usuario,
		OPERADOR_USUARIO.id_nivel,
		NIVEL.v_desc_nivel
	FROM
		tb_operador_usuario OPERADOR_USUARIO
		INNER JOIN tb_nivel NIVEL ON NIVEL.id_nivel=OPERADOR_USUARIO.id_nivel
	WHERE
		OPERADOR_USUARIO.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR OPERADOR_USUARIO.v_nombre_operador_usuario LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR OPERADOR_USUARIO.v_cod_operador_usuario LIKE '%' + @texto_buscar + '%' ))
	ORDER BY OPERADOR_USUARIO.v_nombre_operador_usuario
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_OPERADOR_USUARIOS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_SEL_OPERADOR_USUARIOS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		OPERADOR_USUARIO.id_operador_usuario,
		OPERADOR_USUARIO.v_cod_operador_usuario,
		OPERADOR_USUARIO.v_nombre_operador_usuario,
		OPERADOR_USUARIO.id_nivel,
		NIVEL.v_desc_nivel
	FROM
		tb_operador_usuario OPERADOR_USUARIO
		INNER JOIN tb_nivel NIVEL ON NIVEL.id_nivel=OPERADOR_USUARIO.id_nivel
	WHERE
		OPERADOR_USUARIO.id_operador_usuario=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_OPERADOR_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_OPERADOR_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		OPERADOR.id_operador,
		OPERADOR.v_cod_operador,
		OPERADOR.v_nombre_operador,
		OPERADOR.v_apepaterno_operador,
		OPERADOR.v_apematerno_operador,
		OPERADOR.id_nivel,
		OPERADOR.v_usuario_operador,
		OPERADOR.v_clave_operador
	FROM
		tb_operador OPERADOR
	WHERE
		id_operador=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_PRODUCTO_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_PRODUCTO_DESP]

AS
BEGIN
	SELECT
		0 AS id_producto,
		' -- SELECCIONE -- ' AS v_nom_producto
	UNION ALL
	SELECT
		id_producto,
		v_nom_producto
	FROM
		tb_producto
	WHERE
		i_estado_registro=1;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_PRODUCTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_PRODUCTOS]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		PRODUCTO.id_producto,
		PRODUCTO.v_cod_producto,
		PRODUCTO.v_nom_producto,
		PRODUCTO.d_p_venta,
		PRODUCTO.d_c_compra,
		PRODUCTO.i_flg_afecto_igv,
		PRODUCTO.i_flg_afecto_isc,
		PRODUCTO.v_uni_med
	FROM
		tb_producto PRODUCTO
	WHERE
		PRODUCTO.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR PRODUCTO.v_cod_producto LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR PRODUCTO.v_nom_producto LIKE '%' + @texto_buscar + '%' ))
	ORDER BY PRODUCTO.v_nom_producto
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_PRODUCTOS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_PRODUCTOS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		PRODUCTO.id_producto,
		PRODUCTO.v_cod_producto,
		PRODUCTO.v_nom_producto,
		PRODUCTO.d_p_venta,
		PRODUCTO.d_c_compra,
		PRODUCTO.i_flg_afecto_igv,
		PRODUCTO.i_flg_afecto_isc,
		PRODUCTO.v_uni_med
	FROM
		tb_producto PRODUCTO
	WHERE
		id_producto=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_PROVINCIA_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_PROVINCIA_DESP]
	@id_departamento INT
AS
BEGIN
	SELECT
		0 AS id_provincia,
		' -- SELECCIONE -- ' AS v_desc_provincia
	UNION ALL
	SELECT
		id_provincia,
		v_desc_provincia
	FROM
		tb_provincia
	WHERE
		i_estado_registro=1
		AND id_departamento=@id_departamento;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_SURTIDOR_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_SURTIDOR_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		SURTIDOR.id_surtidor,
		SURTIDOR.v_cod_surtidor,
		SURTIDOR.v_denominacion_surtidor
		
	FROM
		tb_surtidor SURTIDOR
	WHERE
		id_surtidor=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_SURTIDORES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_SURTIDORES]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		SURTIDOR.id_surtidor,
		SURTIDOR.v_cod_surtidor,
		SURTIDOR.v_denominacion_surtidor
	
	FROM
		tb_surtidor SURTIDOR
	WHERE
		SURTIDOR.i_estado_registro=1
		AND (@texto_buscar IS NULL OR SURTIDOR.v_denominacion_surtidor LIKE '%' + @texto_buscar + '%' 
		OR (@texto_buscar IS NULL OR SURTIDOR.v_cod_surtidor LIKE '%' + @texto_buscar + '%' ))
	ORDER BY SURTIDOR.v_denominacion_surtidor
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TABLAS_TIPO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_TABLAS_TIPO] 
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		TABLAS_TIPO.id_tabla_tipo,
		TABLAS_TIPO.v_cod_tabla_tipo,
		TABLAS_TIPO.v_item_tabla_tipo,
		TABLAS_TIPO.v_denominacion_tabla_tipo
	FROM
		tb_tablas_tipo TABLAS_TIPO
	WHERE
		TABLAS_TIPO.i_estado_registro=1
		AND TABLAS_TIPO.v_item_tabla_tipo  IS NOT NULL
		AND ((@texto_buscar IS NULL OR TABLAS_TIPO.v_denominacion_tabla_tipo LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR TABLAS_TIPO.v_item_tabla_tipo LIKE '%' + @texto_buscar + '%' ) 
		OR (@texto_buscar IS NULL OR TABLAS_TIPO.v_cod_tabla_tipo LIKE '%' + @texto_buscar + '%' ) )

	ORDER BY TABLAS_TIPO.v_denominacion_tabla_tipo
END
GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TABLAS_TIPO_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_TABLAS_TIPO_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		TABLAS_TIPO.id_tabla_tipo,
		TABLAS_TIPO.v_cod_tabla_tipo,
		TABLAS_TIPO.v_item_tabla_tipo,
		TABLAS_TIPO.v_denominacion_tabla_tipo
	
	FROM
		tb_tablas_tipo TABLAS_TIPO
	WHERE
		id_tabla_tipo=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TIPO_CAMBIO_X_FECHA]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_TIPO_CAMBIO_X_FECHA]
	@v_fecha VARCHAR(10)
AS
BEGIN
	SELECT
		CAMBIO.id_tcambio,
		CAMBIO.v_fecha,
		CAMBIO.d_venta,
		CAMBIO.d_compra
	FROM
		tb_tcambio CAMBIO
	WHERE
		CONVERT(DATE,CAMBIO.v_fecha)=CONVERT(DATE,@v_fecha);
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TIPO_DOCUMENTO_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_TIPO_DOCUMENTO_DESP]

AS
BEGIN
	SELECT
		0 AS id_tipo_documento,
		' -- SELECCIONE -- ' AS v_abrev_tipo_documento
	UNION ALL
	SELECT
		id_tipo_documento,
		v_abrev_tipo_documento
	FROM
		tb_tipo_documento
	WHERE
		i_estado_registro=1;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TIPO_PERFIL_DESP]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_TIPO_PERFIL_DESP]

AS
BEGIN
	SELECT
		0 AS id_tipo_perfil,
		' -- SELECCIONE -- ' AS Tipo_perfil
	UNION ALL
	SELECT
		id_tipo_perfil,
		Tipo_perfil
	FROM
		tb_Tipo_Perfil
	WHERE
		id_registro=1;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TIPOS_CAMBIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_TIPOS_CAMBIO]
AS
BEGIN
	SELECT
		CAMBIO.id_tcambio,
		CAMBIO.v_fecha,
		CAMBIO.d_venta,
		CAMBIO.d_compra
	FROM
		tb_tcambio CAMBIO
	ORDER BY CAMBIO.v_fecha DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TURNOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADO ================================

CREATE PROCEDURE [dbo].[USP_SEL_TURNOS]
	@v_hora_inicio VARCHAR(20),
	@v_hora_fin VARCHAR(20)
AS
BEGIN
	SELECT
		TURNOS.id_turno,
		TURNOS.v_cod_turno,
		TURNOS.v_denominacion_turno,
		TURNOS.v_hora_inicio,
		TURNOS.v_hora_fin
	
	FROM
		tb_turnos TURNOS
	WHERE
		TURNOS.i_estado_registro=1
		--AND ((@v_hora_inicio IS NULL OR TURNOS.v_hora_inicio LIKE '%' + @v_hora_inicio + '%' )
		--OR (@v_hora_fin IS NULL OR TURNOS.v_hora_fin LIKE '%' + @v_hora_fin + '%' ))
		AND (CAST(v_hora_inicio as time) <= CAST(@v_hora_inicio as time) AND CAST(v_hora_fin as time) >= cast(@v_hora_inicio as time))
	ORDER BY TURNOS.v_denominacion_turno

END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_TURNOS_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ LISTADOS ================================

CREATE PROCEDURE [dbo].[USP_SEL_TURNOS_X_ID]
	@ID INT
AS
BEGIN
	SELECT
		TURNOS.id_turno,
		TURNOS.v_cod_turno,
		TURNOS.v_denominacion_turno,
		TURNOS.v_hora_inicio,
		TURNOS.v_hora_fin
		
	FROM
		tb_turnos TURNOS
	WHERE
		id_turno=@ID;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_USUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_USUARIO]
	@texto_buscar VARCHAR(20)
AS
BEGIN
	SELECT
		USUARIOS.id_usuario,
		USUARIOS.v_nom_usuario,
		USUARIOS.v_usuario
	FROM
		tb_Usuarios USUARIOS
	WHERE
		USUARIOS.i_estado_registro=1
		AND ((@texto_buscar IS NULL OR USUARIOS.v_nom_usuario LIKE '%' + @texto_buscar + '%' )
		OR (@texto_buscar IS NULL OR USUARIOS.v_usuario LIKE '%' + @texto_buscar + '%' ))
	ORDER BY USUARIOS.v_usuario
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_USUARIO_LOGIN]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_SEL_USUARIO_LOGIN]
	@v_usuario VARCHAR(20),
	@v_clave_usuario VARCHAR(20)
AS
BEGIN
	SELECT
		USUARIO.id_usuario,
		USUARIO.v_nom_usuario,
		USUARIO.v_usuario,
		USUARIO.v_clave_usuario
	FROM
		TB_USUARIOS USUARIO
	WHERE
		USUARIO.i_estado_registro=1
		AND USUARIO.v_usuario=@v_usuario
		AND USUARIO.v_clave_usuario=@v_clave_usuario;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_SEL_USUARIO_X_ID]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_SEL_USUARIO_X_ID]
	@id INT
AS
BEGIN
	SELECT
		USUARIO.id_usuario,
		USUARIO.v_nom_usuario,
		USUARIO.v_usuario,
		USUARIO.v_clave_usuario,
		USUARIO.id_tipo_perfil,
		TPERFIL.Tipo_perfil
	FROM
		tb_Usuarios USUARIO
	LEFT JOIN tb_Tipo_Perfil TPERFIL ON TPERFIL.id_tipo_perfil=USUARIO.id_tipo_perfil
	WHERE
		id_usuario=@id;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_CLIENTES]
	@id_cliente INT OUTPUT,
	@id_tipo_documento INT,
	@v_num_documento VARCHAR(11),
	@v_nom_cliente VARCHAR(50),
	@v_direccion_cliente VARCHAR(100),
	@id_departamento INT,
	@id_provincia INT,
	@id_distrito INT,
	@v_ubigeo INT,
	@i_chk_promo_vigentes INT,
	@i_chk_aceptar_vtas_credito INT,
	@d_linea_credito DECIMAL(18,2),
	@d_credito_utilizado DECIMAL(18,2),
	@d_credito_disponible DECIMAL(18,2),
	@id_usuario_modificacion INT
	
AS
BEGIN
	UPDATE tb_cliente SET
		id_tipo_documento=@id_tipo_documento,
		v_num_documento=@v_num_documento,
		v_nom_cliente=@v_nom_cliente,
		v_direccion_cliente=@v_direccion_cliente,
		id_departamento=@id_departamento,
		id_provincia=@id_provincia,
		id_distrito=@id_distrito,
		v_ubigeo=@v_ubigeo,
		i_chk_promo_vigentes=@i_chk_promo_vigentes,
		i_chk_aceptar_vtas_credito=@i_chk_aceptar_vtas_credito,
		d_linea_credito=@d_linea_credito,
		d_credito_utilizado=@d_credito_utilizado,
		d_credito_disponible=@d_credito_disponible,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_cliente=@id_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_DESCUENTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_DESCUENTO]
	@id_nivel_dto_cliente INT OUTPUT,
	@id_cliente INT,
	@id_producto INT,
	@d_cant_minima DECIMAL(18,0),
	@d_dto_cantidad DECIMAL(18,0)
	
AS
BEGIN
	UPDATE tb_nivel_dto_cliente SET
		id_cliente=@id_cliente,
		id_producto =@id_producto ,
		d_cant_minima=@d_cant_minima

	WHERE
		id_nivel_dto_cliente=@id_nivel_dto_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_DOCUMENTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_UPD_DOCUMENTOS]
	@id_documento INT,
	@v_cod_documento VARCHAR(20),
	@v_deno_documento VARCHAR(50),
	@v_serie_documento VARCHAR(4),
	@v_num_documento VARCHAR(20),
	@id_usuario_modificacion INT	
AS
BEGIN
	UPDATE tb_documentos SET	
		v_cod_documento=@v_cod_documento,
		v_deno_documento =@v_deno_documento,
		v_serie_documento=@v_serie_documento,
		v_num_documento =@v_num_documento,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_documento=@id_documento;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_EMPRESA]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[USP_UPD_EMPRESA]
	@id_empresa INT,
	@v_num_documento VARCHAR(50),
	@v_nom_empresa VARCHAR(100),
	@v_direccion_empresa VARCHAR(200),
	@id_departamento INT,
	@id_provincia INT,
	@id_distrito INT,
	@v_ubigeo VARCHAR(50),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_empresa SET
		v_num_documento=@v_num_documento,
		v_nom_empresa=@v_nom_empresa,
		v_direccion_empresa=@v_direccion_empresa,
		id_departamento=@id_departamento,
		id_provincia=@id_provincia,
		id_distrito=@id_distrito,
		v_ubigeo=@v_ubigeo,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_empresa=@id_empresa;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_CLIENTES]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_CLIENTES]
	@id_cliente INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_cliente SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_cliente=@id_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_DESCUENTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_DESCUENTO]
	@id_nivel_dto_cliente INT
AS
BEGIN
	UPDATE tb_nivel_dto_cliente SET
		i_estado_registro=2
	WHERE
		id_nivel_dto_cliente=@id_nivel_dto_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_DOCUMENTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_DOCUMENTOS]
	@id_documento INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_documentos SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_documento=@id_documento;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_EMPRESA]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_EMPRESA]
	@id_empresa INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_empresa SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_empresa=@id_empresa;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_ISLAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_ISLAS]
	@id_isla INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_islas SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_isla=@id_isla;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_LADOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_LADOS]
	@id_lados INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_lados SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_lados=@id_lados;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_OPERADOR_USUARIOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_OPERADOR_USUARIOS]
	@id_operador_usuario INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_operador_usuario SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_operador_usuario=@id_operador_usuario;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_PRODUCTOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_PRODUCTOS]
	@id_producto INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_producto SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_producto=@id_producto;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_SURTIDOR]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_SURTIDOR]
	@id_surtidor INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_surtidor SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_surtidor=@id_surtidor;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_TURNO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD ESTADO ================================

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_TURNO]
	@id_turno INT,
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_turnos SET
		i_estado_registro=2,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_turno=@id_turno;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ESTADO_USUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_UPD_ESTADO_USUARIO]
	@id_usuario INT	
AS
BEGIN
	UPDATE tb_Usuarios SET
		i_estado_registro=2				
	WHERE
		id_usuario=@id_usuario;
END


GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_ISLAS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_ISLAS]
	@id_isla INT,
	@v_cod_isla VARCHAR(50),
	@v_denominacion_isla VARCHAR(50),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_islas SET
		v_cod_isla=@v_cod_isla,
		v_denominacion_isla=@v_denominacion_isla,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_isla=@id_isla;
END


GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_LADOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_UPD_LADOS]
	@id_lados INT,
	@v_cod_lados VARCHAR(50),
	@v_denominacion_lados VARCHAR(50),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_lados SET
		v_cod_lados=@v_cod_lados,
		v_denominacion_lados=@v_denominacion_lados,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_lados=@id_lados;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_NIVEL_DTO_CLIENTE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_UPD_NIVEL_DTO_CLIENTE]
	@id_nivel_dto_cliente INT,
	@id_cliente INT,
	@id_producto INT,
	@d_cant_minima DECIMAL(18,2),
	@d_dto_cantidad DECIMAL(18,2)
AS
BEGIN
	UPDATE tb_nivel_dto_cliente SET
		id_cliente=@id_cliente,
		id_producto=@id_producto,
		d_cant_minima =@d_cant_minima,
		d_dto_cantidad=@d_dto_cantidad
	WHERE
		id_nivel_dto_cliente=@id_nivel_dto_cliente;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_OPERADOR_USUARIOS]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USP_UPD_OPERADOR_USUARIOS]
	@id_operador_usuario INT OUTPUT,
	@v_cod_operador_usuario VARCHAR(50),
	@v_nombre_operador_usuario VARCHAR(50),
	@id_nivel INT,
	@id_usuario_modificacion INT
	
AS
BEGIN
	UPDATE tb_operador_usuario SET
		v_cod_operador_usuario=@v_cod_operador_usuario,
		v_nombre_operador_usuario=@v_nombre_operador_usuario,
		id_nivel=@id_nivel,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_operador_usuario=@id_operador_usuario;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_PRODUCTO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_PRODUCTO]
	@id_producto INT,
	@v_cod_producto VARCHAR(20),
	@v_nom_producto VARCHAR(50),
	@d_p_venta DECIMAL(18,2),
	@d_c_compra DECIMAL(18,2),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_producto SET
		v_cod_producto=@v_cod_producto,
		v_nom_producto=@v_nom_producto,
		d_p_venta=@d_p_venta,
		d_c_compra=@d_c_compra,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_producto=@id_producto;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_SURTIDOR]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_SURTIDOR]
	@id_surtidor INT,
	@v_cod_surtidor VARCHAR(50),
	@v_denominacion_surtidor VARCHAR(50),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_surtidor SET
		v_cod_surtidor=@v_cod_surtidor,
		v_denominacion_surtidor=@v_denominacion_surtidor,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_surtidor=@id_surtidor;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_TIPO_CAMBIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_UPD_TIPO_CAMBIO]
	@id_tcambio INT,
	@v_fecha VARCHAR(10),
	@d_venta DECIMAL(18,2),
	@d_compra DECIMAL(18,2)
AS
BEGIN
	UPDATE tb_tcambio SET
		v_fecha=@v_fecha,
		d_venta=@d_venta,
		d_compra =@d_compra
	WHERE
		id_tcambio=@id_tcambio;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_TURNO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--================================ UPD================================

CREATE PROCEDURE [dbo].[USP_UPD_TURNO]
	@id_turno INT,
	@v_cod_turno VARCHAR(50),
	@v_denominacion_turno VARCHAR(50),
	@v_hora_inicio VARCHAR(8),
	@v_hora_fin VARCHAR(8),
	@id_usuario_modificacion INT
AS
BEGIN
	UPDATE tb_turnos SET
		v_cod_turno=@v_cod_turno,
		v_denominacion_turno=@v_denominacion_turno,
		v_hora_inicio=@v_hora_inicio,
		v_hora_fin=@v_hora_fin,
		id_usuario_modificacion=@id_usuario_modificacion,
		v_fecha_modificacion=GETDATE()
	WHERE
		id_turno=@id_turno;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_USUARIO]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_UPD_USUARIO]
	@id_usuario	INT,
	@v_nom_usuario VARCHAR(20),
	@v_usuario VARCHAR(20),
	@v_clave_usuario VARCHAR(20),
	@id_tipo_perfil	INT
AS
BEGIN
	UPDATE tb_Usuarios SET
		v_nom_usuario=@v_nom_usuario,
		v_usuario=@v_usuario,
		v_clave_usuario=@v_clave_usuario,
		id_tipo_perfil=@id_tipo_perfil		
	WHERE
		id_usuario=@id_usuario;
END

GO
/****** Object:  StoredProcedure [dbo].[USP_UPD_USUARIO_CAMBIO_CLAVE]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Danfer Galindo Carrera>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_UPD_USUARIO_CAMBIO_CLAVE]
	@id_usuario int,
	@v_clave_usuario VARCHAR(20),
	@v_nueva_usuario VARCHAR(20)
AS
BEGIN
	DECLARE @CLAVE VARCHAR(20);
	SET @CLAVE = ISNULL((SELECT v_clave_usuario FROM tb_Usuarios WHERE i_estado_registro=1 AND id_usuario=@id_usuario),'');
	
	IF (@CLAVE <> '')
		UPDATE tb_Usuarios SET
			v_clave_usuario=@v_nueva_usuario
		WHERE
			id_usuario=@id_usuario;

	IF (@CLAVE <> '')
			SELECT 'EXITO' AS MSJ;
	ELSE
		SELECT 'ERROR' AS MSJ;
END
GO
/****** Object:  StoredProcedure [dbo].[usuarioslistado]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[usuarioslistado]
	As
	Select DNI_US, USUARIO from usuarios
	return
	Select DNI_US, USUARIO, CATEGORIA from usuarios

	--registrar usuarios
if object_id('p_REGISTRAR_usuarios') is Not null
	drop procedure p_REGISTRAR_usuarios

GO
/****** Object:  StoredProcedure [dbo].[validar_usuario]    Script Date: 12/07/2017 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	--para ingresar al sistema
create proc [dbo].[validar_usuario]
@log varchar (20),
@pas varchar(20),
@CAT VARCHAR (30)
As
Select * from usuarios
Where USUARIO=@log and PASSWOR=@pas AND CATEGORIA= @CAT

GO
