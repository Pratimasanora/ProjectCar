namespace CarMVCProjectAss.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userInfoUpadate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ConsumerId", c => c.String());
            DropColumn("dbo.Cars", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "UserId", c => c.String());
            DropColumn("dbo.Cars", "ConsumerId");
        }
    }
}
