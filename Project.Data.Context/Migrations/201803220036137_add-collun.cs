namespace Project.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcollun : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dado", new[] { "codCategoria" });
            RenameColumn(table: "dbo.Dado", name: "codCategoria", newName: "cod_categoria");
            AlterColumn("dbo.Dado", "cod_categoria", c => c.Long(nullable: false));
            CreateIndex("dbo.Dado", "cod_categoria");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dado", new[] { "cod_categoria" });
            AlterColumn("dbo.Dado", "cod_categoria", c => c.Long());
            RenameColumn(table: "dbo.Dado", name: "cod_categoria", newName: "codCategoria");
            CreateIndex("dbo.Dado", "codCategoria");
        }
    }
}
