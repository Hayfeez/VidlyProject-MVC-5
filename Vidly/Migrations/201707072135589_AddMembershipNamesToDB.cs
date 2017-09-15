namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipNamesToDB : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set MembershipName='Pay As You Go' where id=1");
            Sql("Update MembershipTypes set MembershipName='Monthly' where id=2");
            Sql("Update MembershipTypes set MembershipName='Quarterly' where id=3");
            Sql("Update MembershipTypes set MembershipName='Annual' where id=4");

        }
        
        public override void Down()
        {
        }
    }
}
