namespace Project.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02032018 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dado",
                c => new
                    {
                        id_dado = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        referencia = c.String(maxLength: 100, unicode: false),
                        palavra_chave = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        oferta = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        texto = c.String(maxLength: 100, unicode: false),
                        resumo = c.String(maxLength: 100, unicode: false),
                        valor = c.String(maxLength: 100, unicode: false),
                        meta = c.String(maxLength: 100, unicode: false),
                        data = c.DateTime(nullable: false),
                        visivel = c.Boolean(nullable: false),
                        ativo = c.Boolean(nullable: false),
                        destaque = c.Boolean(nullable: false),
                        cod_pagina = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_dado)
                .ForeignKey("dbo.Pagina", t => t.cod_pagina)
                .Index(t => t.cod_pagina);
            
            CreateTable(
                "dbo.ImagemDado",
                c => new
                    {
                        id_ImagemDado = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        cod_dado = c.Long(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.id_ImagemDado)
                .ForeignKey("dbo.Dado", t => t.cod_dado)
                .Index(t => t.cod_dado);
            
            CreateTable(
                "dbo.Pagina",
                c => new
                    {
                        id_pagina = c.Long(nullable: false, identity: true),
                        nome = c.String(maxLength: 100, unicode: false),
                        multi = c.Boolean(nullable: false),
                        cod_pagina_controle = c.Long(nullable: false),
                        cod_upload_imagem = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_pagina)
                .ForeignKey("dbo.PaginaControle", t => t.cod_pagina_controle)
                .ForeignKey("dbo.UploadImagem", t => t.cod_upload_imagem)
                .Index(t => t.cod_pagina_controle)
                .Index(t => t.cod_upload_imagem);
            
            CreateTable(
                "dbo.PaginaControle",
                c => new
                    {
                        id_pagina_controle = c.Long(nullable: false, identity: true),
                        nome = c.String(maxLength: 100, unicode: false),
                        endereco = c.String(maxLength: 100, unicode: false),
                        fixa = c.Boolean(nullable: false),
                        cod_grupo_pagina = c.Long(nullable: false),
                        ordem = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id_pagina_controle)
                .ForeignKey("dbo.GrupoPaginas", t => t.cod_grupo_pagina)
                .Index(t => t.cod_grupo_pagina);
            
            CreateTable(
                "dbo.GrupoPaginas",
                c => new
                    {
                        id_grupo_paginas = c.Long(nullable: false, identity: true),
                        nome = c.String(maxLength: 100, unicode: false),
                        ordem = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id_grupo_paginas);
            
            CreateTable(
                "dbo.UploadImagem",
                c => new
                    {
                        id_upload_imagem = c.Long(nullable: false, identity: true),
                        quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id_upload_imagem);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dado", "cod_pagina", "dbo.Pagina");
            DropForeignKey("dbo.Pagina", "cod_upload_imagem", "dbo.UploadImagem");
            DropForeignKey("dbo.Pagina", "cod_pagina_controle", "dbo.PaginaControle");
            DropForeignKey("dbo.PaginaControle", "cod_grupo_pagina", "dbo.GrupoPaginas");
            DropForeignKey("dbo.ImagemDado", "cod_dado", "dbo.Dado");
            DropIndex("dbo.PaginaControle", new[] { "cod_grupo_pagina" });
            DropIndex("dbo.Pagina", new[] { "cod_upload_imagem" });
            DropIndex("dbo.Pagina", new[] { "cod_pagina_controle" });
            DropIndex("dbo.ImagemDado", new[] { "cod_dado" });
            DropIndex("dbo.Dado", new[] { "cod_pagina" });
            DropTable("dbo.UploadImagem");
            DropTable("dbo.GrupoPaginas");
            DropTable("dbo.PaginaControle");
            DropTable("dbo.Pagina");
            DropTable("dbo.ImagemDado");
            DropTable("dbo.Dado");
        }
    }
}
