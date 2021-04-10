namespace LaurenIp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Simulas",
                c => new
                    {
                        IdCodigo = c.Int(nullable: false, identity: true),
                        NomeProjeto = c.String(),
                        DataInico = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        ValorProjeto = c.Single(nullable: false),
                        RiscoEnum = c.Int(nullable: false),
                        Participantes = c.String(),
                    })
                .PrimaryKey(t => t.IdCodigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Simulas");
        }
    }
}
