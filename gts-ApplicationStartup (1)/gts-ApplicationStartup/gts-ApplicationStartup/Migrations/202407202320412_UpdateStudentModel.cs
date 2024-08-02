namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "Photo");
            DropColumn("dbo.Students", "RowVersion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Students", "Photo", c => c.Binary());
        }
    }
}
