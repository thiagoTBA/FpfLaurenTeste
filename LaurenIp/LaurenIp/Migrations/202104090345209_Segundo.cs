namespace LaurenIp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segundo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Simulas", "NomeProjeto", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Simulas", "ValorProjeto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Simulas", "Participantes", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Simulas", "Participantes", c => c.String());
            AlterColumn("dbo.Simulas", "ValorProjeto", c => c.Single(nullable: false));
            AlterColumn("dbo.Simulas", "NomeProjeto", c => c.String());
        }
    }
}
