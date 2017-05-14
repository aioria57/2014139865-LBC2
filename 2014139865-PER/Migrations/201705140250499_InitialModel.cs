namespace _2014139865_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asiento",
                c => new
                    {
                        AsientoId = c.Int(nullable: false),
                        CarroId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        CinturonId = c.Int(nullable: false),
                        Carro_CarroId = c.Int(),
                        Carro_EnsambladoraId = c.Int(),
                    })
                .PrimaryKey(t => new { t.AsientoId, t.CarroId })
                .ForeignKey("dbo.Cinturon", t => t.CinturonId, cascadeDelete: true)
                .ForeignKey("dbo.Carro", t => new { t.Carro_CarroId, t.Carro_EnsambladoraId })
                .Index(t => t.CinturonId)
                .Index(t => new { t.Carro_CarroId, t.Carro_EnsambladoraId });
            
            CreateTable(
                "dbo.Cinturon",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Carro",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        EnsambladoraId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        NumSerieMotor = c.String(),
                        NumSerieChasis = c.String(),
                        VolanteId = c.Int(nullable: false),
                        ParabrisasId = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        Ensambladora_EnsambladoraId = c.Int(nullable: false),
                        Ensambladora_EnsambladoraId1 = c.Int(),
                    })
                .PrimaryKey(t => new { t.CarroId, t.EnsambladoraId })
                .ForeignKey("dbo.Ensambladora", t => t.Ensambladora_EnsambladoraId)
                .ForeignKey("dbo.Parabrisas", t => t.ParabrisasId, cascadeDelete: true)
                .ForeignKey("dbo.Propietario", t => t.PropietarioId, cascadeDelete: true)
                .ForeignKey("dbo.Volante", t => t.VolanteId, cascadeDelete: true)
                .ForeignKey("dbo.Ensambladora", t => t.Ensambladora_EnsambladoraId1)
                .Index(t => t.VolanteId)
                .Index(t => t.ParabrisasId)
                .Index(t => t.PropietarioId)
                .Index(t => t.Ensambladora_EnsambladoraId)
                .Index(t => t.Ensambladora_EnsambladoraId1);
            
            CreateTable(
                "dbo.Ensambladora",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                        TipoCarro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Llanta",
                c => new
                    {
                        LlantaId = c.Int(nullable: false),
                        CarroId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        Carro_CarroId = c.Int(),
                        Carro_EnsambladoraId = c.Int(),
                    })
                .PrimaryKey(t => new { t.LlantaId, t.CarroId })
                .ForeignKey("dbo.Carro", t => new { t.Carro_CarroId, t.Carro_EnsambladoraId })
                .Index(t => new { t.Carro_CarroId, t.Carro_EnsambladoraId });
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietario",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volante",
                c => new
                    {
                        VolanteId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.VolanteId);
            
            CreateTable(
                "dbo.Automovil",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        EnsambladoraId = c.Int(nullable: false),
                        TipoAuto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CarroId, t.EnsambladoraId })
                .ForeignKey("dbo.Carro", t => new { t.CarroId, t.EnsambladoraId })
                .Index(t => new { t.CarroId, t.EnsambladoraId });
            
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        EnsambladoraId = c.Int(nullable: false),
                        TipoBus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CarroId, t.EnsambladoraId })
                .ForeignKey("dbo.Carro", t => new { t.CarroId, t.EnsambladoraId })
                .Index(t => new { t.CarroId, t.EnsambladoraId });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bus", new[] { "CarroId", "EnsambladoraId" }, "dbo.Carro");
            DropForeignKey("dbo.Automovil", new[] { "CarroId", "EnsambladoraId" }, "dbo.Carro");
            DropForeignKey("dbo.Carro", "Ensambladora_EnsambladoraId1", "dbo.Ensambladora");
            DropForeignKey("dbo.Carro", "VolanteId", "dbo.Volante");
            DropForeignKey("dbo.Carro", "PropietarioId", "dbo.Propietario");
            DropForeignKey("dbo.Carro", "ParabrisasId", "dbo.Parabrisas");
            DropForeignKey("dbo.Llanta", new[] { "Carro_CarroId", "Carro_EnsambladoraId" }, "dbo.Carro");
            DropForeignKey("dbo.Carro", "Ensambladora_EnsambladoraId", "dbo.Ensambladora");
            DropForeignKey("dbo.Asiento", new[] { "Carro_CarroId", "Carro_EnsambladoraId" }, "dbo.Carro");
            DropForeignKey("dbo.Asiento", "CinturonId", "dbo.Cinturon");
            DropIndex("dbo.Bus", new[] { "CarroId", "EnsambladoraId" });
            DropIndex("dbo.Automovil", new[] { "CarroId", "EnsambladoraId" });
            DropIndex("dbo.Llanta", new[] { "Carro_CarroId", "Carro_EnsambladoraId" });
            DropIndex("dbo.Carro", new[] { "Ensambladora_EnsambladoraId1" });
            DropIndex("dbo.Carro", new[] { "Ensambladora_EnsambladoraId" });
            DropIndex("dbo.Carro", new[] { "PropietarioId" });
            DropIndex("dbo.Carro", new[] { "ParabrisasId" });
            DropIndex("dbo.Carro", new[] { "VolanteId" });
            DropIndex("dbo.Asiento", new[] { "Carro_CarroId", "Carro_EnsambladoraId" });
            DropIndex("dbo.Asiento", new[] { "CinturonId" });
            DropTable("dbo.Bus");
            DropTable("dbo.Automovil");
            DropTable("dbo.Volante");
            DropTable("dbo.Propietario");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llanta");
            DropTable("dbo.Ensambladora");
            DropTable("dbo.Carro");
            DropTable("dbo.Cinturon");
            DropTable("dbo.Asiento");
        }
    }
}
