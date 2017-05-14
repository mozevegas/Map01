namespace Map01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Landmarks", "Lat", c => c.Double());
            AlterColumn("dbo.Landmarks", "Long", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Landmarks", "Long", c => c.Int(nullable: false));
            AlterColumn("dbo.Landmarks", "Lat", c => c.Int(nullable: false));
        }
    }
}
