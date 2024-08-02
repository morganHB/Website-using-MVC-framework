namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRowVersionToStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "RowVersion");
        }
    }
}
