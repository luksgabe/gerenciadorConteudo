namespace Project.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altercollun : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuario", "senha", c => c.String(maxLength: 1000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuario", "senha", c => c.Int(nullable: false));
        }
    }
}
