namespace Project.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _21032018 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        id_categoria = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_pagina = c.Long(nullable: false),
                        cod_subSegmento = c.Long(nullable: false),
                        Categoria_id = c.Long(),
                    })
                .PrimaryKey(t => t.id_categoria)
                .ForeignKey("dbo.Categoria", t => t.Categoria_id)
                .ForeignKey("dbo.Pagina", t => t.cod_pagina)
                .ForeignKey("dbo.SubSegmento", t => t.cod_subSegmento)
                .Index(t => t.cod_pagina)
                .Index(t => t.cod_subSegmento)
                .Index(t => t.Categoria_id);
            
            CreateTable(
                "dbo.ImagemCategoria",
                c => new
                    {
                        id_imagem_categoria = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_categoria = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_imagem_categoria)
                .ForeignKey("dbo.Categoria", t => t.cod_categoria)
                .Index(t => t.cod_categoria);
            
            CreateTable(
                "dbo.Segmento",
                c => new
                    {
                        id_segmento = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_pagina = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_segmento)
                .ForeignKey("dbo.Pagina", t => t.cod_pagina)
                .Index(t => t.cod_pagina);
            
            CreateTable(
                "dbo.ImagemSegmento",
                c => new
                    {
                        id_imagem_segmento = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_segmento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_imagem_segmento)
                .ForeignKey("dbo.Segmento", t => t.cod_segmento)
                .Index(t => t.cod_segmento);
            
            CreateTable(
                "dbo.SubSegmento",
                c => new
                    {
                        id_subSegmento = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_pagina = c.Long(nullable: false),
                        cod_segmento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_subSegmento)
                .ForeignKey("dbo.Pagina", t => t.cod_pagina)
                .ForeignKey("dbo.Segmento", t => t.cod_segmento)
                .Index(t => t.cod_pagina)
                .Index(t => t.cod_segmento);
            
            CreateTable(
                "dbo.ImagemSubSeg",
                c => new
                    {
                        id_imagem_subSegmento = c.Long(nullable: false, identity: true),
                        ordem = c.Int(nullable: false),
                        nome = c.String(maxLength: 100, unicode: false),
                        descricao = c.String(maxLength: 100, unicode: false),
                        chave = c.String(maxLength: 100, unicode: false),
                        visivel = c.Boolean(nullable: false),
                        cod_subSegmento = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.id_imagem_subSegmento)
                .ForeignKey("dbo.SubSegmento", t => t.cod_subSegmento)
                .Index(t => t.cod_subSegmento);
            
            AddColumn("dbo.Dado", "cod_segmento", c => c.Long(nullable: false));
            AddColumn("dbo.Dado", "cod_subSegmento", c => c.Long(nullable: false));
            AddColumn("dbo.Dado", "codCategoria", c => c.Long(nullable: false));
            AddColumn("dbo.Dado", "categoria_id", c => c.Long());
            CreateIndex("dbo.Dado", "cod_segmento");
            CreateIndex("dbo.Dado", "cod_subSegmento");
            CreateIndex("dbo.Dado", "categoria_id");
            AddForeignKey("dbo.Dado", "categoria_id", "dbo.Categoria", "id_categoria");
            AddForeignKey("dbo.Dado", "cod_segmento", "dbo.Segmento", "id_segmento");
            AddForeignKey("dbo.Dado", "cod_subSegmento", "dbo.SubSegmento", "id_subSegmento");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categoria", "cod_subSegmento", "dbo.SubSegmento");
            DropForeignKey("dbo.Categoria", "cod_pagina", "dbo.Pagina");
            DropForeignKey("dbo.Dado", "cod_subSegmento", "dbo.SubSegmento");
            DropForeignKey("dbo.Dado", "cod_segmento", "dbo.Segmento");
            DropForeignKey("dbo.Segmento", "cod_pagina", "dbo.Pagina");
            DropForeignKey("dbo.SubSegmento", "cod_segmento", "dbo.Segmento");
            DropForeignKey("dbo.SubSegmento", "cod_pagina", "dbo.Pagina");
            DropForeignKey("dbo.ImagemSubSeg", "cod_subSegmento", "dbo.SubSegmento");
            DropForeignKey("dbo.ImagemSegmento", "cod_segmento", "dbo.Segmento");
            DropForeignKey("dbo.Dado", "categoria_id", "dbo.Categoria");
            DropForeignKey("dbo.ImagemCategoria", "cod_categoria", "dbo.Categoria");
            DropForeignKey("dbo.Categoria", "Categoria_id", "dbo.Categoria");
            DropIndex("dbo.ImagemSubSeg", new[] { "cod_subSegmento" });
            DropIndex("dbo.SubSegmento", new[] { "cod_segmento" });
            DropIndex("dbo.SubSegmento", new[] { "cod_pagina" });
            DropIndex("dbo.ImagemSegmento", new[] { "cod_segmento" });
            DropIndex("dbo.Segmento", new[] { "cod_pagina" });
            DropIndex("dbo.Dado", new[] { "categoria_id" });
            DropIndex("dbo.Dado", new[] { "cod_subSegmento" });
            DropIndex("dbo.Dado", new[] { "cod_segmento" });
            DropIndex("dbo.ImagemCategoria", new[] { "cod_categoria" });
            DropIndex("dbo.Categoria", new[] { "Categoria_id" });
            DropIndex("dbo.Categoria", new[] { "cod_subSegmento" });
            DropIndex("dbo.Categoria", new[] { "cod_pagina" });
            DropColumn("dbo.Dado", "categoria_id");
            DropColumn("dbo.Dado", "codCategoria");
            DropColumn("dbo.Dado", "cod_subSegmento");
            DropColumn("dbo.Dado", "cod_segmento");
            DropTable("dbo.ImagemSubSeg");
            DropTable("dbo.SubSegmento");
            DropTable("dbo.ImagemSegmento");
            DropTable("dbo.Segmento");
            DropTable("dbo.ImagemCategoria");
            DropTable("dbo.Categoria");
        }
    }
}
