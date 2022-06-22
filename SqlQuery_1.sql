﻿CREATE TABLE [dbo].[Enderecos] (
    [Id] [uniqueidentifier] NOT NULL,
    [Logradouro] [nvarchar](50) NOT NULL,
    [Numero] [nchar](8) NOT NULL,
    [Complemento] [nvarchar](250),
    [Bairro] [nvarchar](100) NOT NULL,
    [Cidade] [nvarchar](100) NOT NULL,
    [Estado] [nvarchar](100) NOT NULL,
    [Cep] [nchar](8) NOT NULL,
    CONSTRAINT [PK_dbo.Enderecos] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Fornecedores] (
    [Id] [uniqueidentifier] NOT NULL,
    [Nome] [nvarchar](200) NOT NULL,
    [Documento] [nchar](14) NOT NULL,
    [TipoFornecedor] [int] NOT NULL,
    [Ativo] [bit] NOT NULL,
    CONSTRAINT [PK_dbo.Fornecedores] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Produtoes] (
    [Id] [uniqueidentifier] NOT NULL,
    [Nome] [nvarchar](200) NOT NULL,
    [Descricao] [nvarchar](100) NOT NULL,
    [Imagem] [nvarchar](100) NOT NULL,
    [Valor] [decimal](18, 2) NOT NULL,
    [DataCadastro] [datetime] NOT NULL,
    [Ativo] [bit] NOT NULL,
    [FornecedorId] [uniqueidentifier] NOT NULL,
    CONSTRAINT [PK_dbo.Produtoes] PRIMARY KEY ([Id])
)
CREATE INDEX [IX_Id] ON [dbo].[Enderecos]([Id])
CREATE INDEX [IX_FornecedorId] ON [dbo].[Produtoes]([FornecedorId])
ALTER TABLE [dbo].[Enderecos] ADD CONSTRAINT [FK_dbo.Enderecos_dbo.Fornecedores_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Fornecedores] ([Id])
ALTER TABLE [dbo].[Produtoes] ADD CONSTRAINT [FK_dbo.Produtoes_dbo.Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [dbo].[Fornecedores] ([Id]) ON DELETE CASCADE
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'202206222233345_AutomaticMigration', N'DevIO.AppMvc.Migrations.Configuration',  0x1F8B0800000000000400ED5B5B6FDB36147E1FB0FF20E871C82CDBDD802EB05B244E52786B92224E8ABE05B474EC10932855A48218C57ED91EF693F6177664DD48EA62D956DC142BF262F1F29D0BCF393CE461FEFDFB9FD1DB27CF351E21E4D4676373D0EB9B0630DB77285B8ECD482C7E7E6DBE7DF3E30FA373C77B323E66E35EC5E37026E363F34188E0D8B2B8FD001EE13D8FDAA1CFFD85E8D9BE6711C7B786FDFE6FD66060014298886518A39B8809EAC1FA033F273EB3211011712F7D075C9EB663CF6C8D6A5C110F78406C189B67F038BDEE4DD92224BD3322480F270B7812A671E25282FCCCC05D980661CC174420B7C7771C6622F4D972166003716F5701E0B8057139A4521C17C3DB0AD41FC60259C5C40CCA8EB8F0BD2D0107AF520D59FAF49DF46CE61A441D9EA3AEC52A967AADC7B179CE1C08C1F64D4327763C71C37860A6E6D38853069CF79275E95DF821031B1C3F04DECB608E0C75F0516E27684EF1DF9131895C11853066108990B847C68768EE52FB0F58DDFA7F021BB3C875659E916BEC531AB0E943E807108AD50D2C5249A68E6958EA3C4B9F984F93E62432BE8B28FEBE42DA64EE426E1156E3F4F7FE32446D47A19FC1A071A1B798C625797A0F6C291EC6E6AFE81E17F4099CAC2185BE63147D0BE7883082AD495F451E34927DAD514DA8EC4774E27B810B1E30D14479D852E2665AA784868D020EFACFA2D80975880387A77BCE059AD257901782E7B6A22BF24897EB98A2D12E428869DC80BB1EC21F6890046E29C2DC1761EA22F4BD1BDF5566E7DDF7B7245C02C6FF5BBF7ECC0C1DD6D6B81C5945646C8C9732CB7B45CCE2E3FF1533AF7CAFC9BB86CF63E567BE1D6D8A5B835F9E2164DED2C0976D26A51E9BB7DEB525F289A08FB938A73E9A3B617BF862E161DD7862E6654D9E98796B5B1EF1D38944358B69DFBDACD182C3726F2954540CD92B52E4CC6E1B26D289F98FEFF1E100F101B81D529B7C850D78EA91257887A7FB91B845403A039B7AC4358D0FE898343D00E2E63FB3490C38DC5EA1781C9B108770512471D806B7D4DB9ED5DD425D6DB2B1AD85EE9ABF6C1D92F498D910B5DA85A4C8930292BEDF4CF9854B96C5E977AF744605EF2A64A189E356E1AED025124EA64CBC1A6A91EC12BC398459D4456A3EB94013B68969A08D47D838282D69C59CDFA3903AF2AC6159CB893EE5C6139C6AD3B5BE4A4651EC952A716C365A6C9C45A620AFDA25EA8D06A8295CF02AC99AC1F34DAF002F36F44DD0B82FE04816DF9B4CD0D071D92813E54D84329B06C4DD2CA236B5E50E14AF444E44EF398300900A139B75B03BF59C88B6336ED2CFC892ACA5D9882A4247DD3237C5916295F36C445DE49F1AECA729676A679BBAE6AED919B820C038B193DBB009E1F6FAB4AD2719C84507B6572FC1014CAF7E5DDA105777AB03D860B285C417A838230F8D97109DCDF35BD5D20E71C721DD24789A85E8C61483CE4068870C6E1AC596558A43258B5441E47DA7024736C80D4859A65D8192FB8B062169AF8A23E978248D6C3845E90BDB6E6FC805D1B551329476DB8184272D91EE94AAEC2DF452950095D5B229D6B58D769210C5C23628A421BEB5D46F834AB29C2C77A8A28E6125858CACE061D5543C4697240830F1912A20698B314BCA1F939F67DB5704BC04C3B279456120E736A724FC108F275A6F7C13ECC0050DB988F3FC3989D3C789E3958629E1A3C61733527A84282F5CE6A2D98CF877767CAB2E04F5EAFCAC50E605CA17DF0CAD45850A47284F5DD7A2884BC28A93EFC477238FD56F20F5B3E562828C22B7B747CBEA033252D6D61E45B9F097A1948EF678D9A5BE0C95B56DC1557A45AF3094B6B547C92EDC6594AC6D0B5EE2EB738591B8A13C7F6469F656DAD14BF65D4A89548769E54E4AF4EAC4A3EAA3740B9F6A9AFC3C5E955C27295EB06E698F205D1DCB3052737B2CFD082E03EA7DED51D3EB11192C6D7A3176986FC89DD860969C6D6F80B5335FACF51517938AF515CDEDB1B29B46459EB4AD3D4A7A6F2883A44D5B48A5DC0E2A82293DCFE3037518EA994B866A3E8D3DB3579552497D484E3D4F29B5D47194A6719B5FD494F2BA64487C2FEC3F5227CEE9662B2EC04B1C72F6D99DB814E52D065C124617C045728B670EFB83A1F61CE7E53C8DB13877DC9DDFC74CB1EB696C7E31FE3A7C692562F4730434BE00A00B0A55C5E89CBD78EEB131FD743F758E8CEB10E53936FAC8F4FEAF5DD82309ED071296DEBBECF5988595205F77F152A592D9A1CAEDF60F532A51D7159BBDDE9D7406AB3E2BE98EDBE2D5C8F6CBD5CD638B97E57E7B5439AB0D738745293D724897A6ACBA4FF7F9D8B8A6828A3C297A8D2FC694DFAD253C366ED123E258A1BD93E8E415048DF78D7D4A8173BA09A0836AFD773BDB582CEF2CACA8B5F0CE609552B7738852B7430488BD4BDD9BEDBB0C5055E6DE295B9081B6C81BEA3CAEAB42690785D122A76B5106EDF77A9D57420F517E6AB8F9FC36EB9C3B984087F5C752D960B7EAEA376038F5972B2FB64A59AE46B42B4336562193932F86F279BCD649BCAB2F8ED51729379428ABC834D69C6A8A984D35CC2A1A69670581AF51E2AC29B935D6EFF45554AB362FB27AB99FC0DA4A2B179ACF52992C5F1BA1EB4AFFAE85B183D3650111FFF3160AA2386D3E66CA167E1641348EB2215A2A73097876458F3E09316D21B6C06E1B385FBF8F4CDF689D7B7370A6EC3A1241245064F0E6EE4A56461C839AE8AFCBAF2ACFA3EB60FD90AF0B11904D1AE782D7EC34A2AE93F37D519138D540C4C1ED1D607BB296182B052C5739D295CF5A02A5EACB63F22D78818B60FC9ACDC823ECC2DB1D87F7B024F62ABBFDAB07D9BC10AADA4767942C43E2F114A3988F9F68C38EF7F4E63FC2B6A0B2B5380000 , N'6.4.4')

