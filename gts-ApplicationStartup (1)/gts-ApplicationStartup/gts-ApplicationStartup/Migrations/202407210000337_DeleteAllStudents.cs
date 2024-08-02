namespace gts_ApplicationStartup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllStudents : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.Students");
        }
        
        public override void Down()
        {
        }
    }
}
