using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Project.Data.Context.Config;
using Project.Data.Context.Mapping;
using ProjetoGerenciadorConteudo.Entities;
using ProjectDomain.Entities;

namespace Project.Data.Context
{
    public class ProjectContext : BaseDbContext
    {
        //static ProjectContext()
        //{
        //    DbContext.SetInitializer(new ContextInitializer());
        //}

        public ProjectContext() : base("projeto_gerenciador_2018")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new DadoMap());
            modelBuilder.Configurations.Add((new ImagemDadoMap()));
            modelBuilder.Configurations.Add((new PaginaMap()));
            modelBuilder.Configurations.Add((new PaginaControleMap()));
            modelBuilder.Configurations.Add((new GrupoPaginasMap()));
            modelBuilder.Configurations.Add((new UploadImagemMap()));
            modelBuilder.Configurations.Add((new SegmentoMap()));
            modelBuilder.Configurations.Add((new SubSegmentoMap()));
            modelBuilder.Configurations.Add((new CategoriaMap()));
            modelBuilder.Configurations.Add((new ImagemSegmentoMap()));
            modelBuilder.Configurations.Add((new ImagemSubSegmentoMap()));
            modelBuilder.Configurations.Add((new ImagemCategoriaMap()));
            modelBuilder.Configurations.Add((new UsuarioMap()));
        }

        public DbSet<Dado> Dado { get; set; }
        public DbSet<ImagemDado> ImagemDado { get; set; }
        public DbSet<Pagina> Pagina { get; set; }
        public DbSet<PaginaControle> PaginaControle { get; set; }
        public DbSet<GrupoPaginas> GrupoPaginas { get; set; }
        public DbSet<UploadImagem> UploadImagem { get; set; }
        public DbSet<Segmento> Segmento { get; set; }
        public DbSet<SubSegmento> Subsegmento { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<ImagemSegmento> ImagemSegmento { get; set; }
        public DbSet<ImagemSubSeg> ImagemSubSegmento { get; set; }
        public DbSet<ImagemCategoria> ImagemCategoria { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
