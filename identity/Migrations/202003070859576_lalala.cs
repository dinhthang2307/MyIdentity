namespace identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lalala : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ByteImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ByteImage");
        }
    }
}
