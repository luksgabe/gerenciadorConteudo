namespace Project.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _23032018 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        id_usuario = c.Long(nullable: false, identity: true),
                        nome = c.String(maxLength: 100, unicode: false),
                        login = c.String(maxLength: 100, unicode: false),
                        senha = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_usuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
