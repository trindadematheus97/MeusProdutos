namespace DevIO.AppMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fk : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produto", newName: "Produtos");
            AddColumn("dbo.Produtos", "Fornecedor_Id", c => c.Guid());
            CreateIndex("dbo.Produtos", "Fornecedor_Id");
            AddForeignKey("dbo.Produtos", "Fornecedor_Id", "dbo.Fornecedores", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "Fornecedor_Id", "dbo.Fornecedores");
            DropIndex("dbo.Produtos", new[] { "Fornecedor_Id" });
            DropColumn("dbo.Produtos", "Fornecedor_Id");
            RenameTable(name: "dbo.Produtos", newName: "Produto");
        }
    }
}
