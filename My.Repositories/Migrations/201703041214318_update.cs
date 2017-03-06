namespace My.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Salute", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Salute");
        }
    }
}
