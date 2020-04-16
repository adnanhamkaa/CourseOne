namespace CourseOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_descriptio_to_TableCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Description");
        }
    }
}
