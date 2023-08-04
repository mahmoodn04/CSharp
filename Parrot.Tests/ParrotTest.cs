using System;
using Xunit;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {

            Parrot norwrgianBlue = new ParrotNerwgian(5 ,true);
            Assert.Equal(0.0, norwrgianBlue.GetSpeed());

        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            Parrot norwrgianBlue = new ParrotNerwgian(1.5, false);
            Assert.Equal(18.0, norwrgianBlue.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {


            Parrot norwrgianBlue = new ParrotNerwgian(4, false);
            Assert.Equal(24.0, norwrgianBlue.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {

            Parrot africanparrot = new ParrotAfrican();
            Assert.Equal(12.0, africanparrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            Parrot africanparrot = new ParrotAfrican(1);
            Assert.Equal(3.0, africanparrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            Parrot africanparrot = new ParrotAfrican(2);
            Assert.Equal(0, africanparrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {

            Parrot europeanParrot = new EuropeanParrot();

            Assert.Equal(12, europeanParrot.GetSpeed());
        }



        [Fact]
        public void GetCryOfEuropeanParrot()
        {
            Parrot europeanParrot = new EuropeanParrot();
            Assert.Equal("Sqoork!", europeanParrot.GetCry());
        }

        [Fact]
        public void GetCryOfAfricanParrot()
        {
            Parrot africanparrot = new ParrotAfrican(2);

            Assert.Equal("Sqaark!", africanparrot.GetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            Parrot norwrgianBlue = new ParrotNerwgian(4);
            Assert.Equal("Bzzzzzz", norwrgianBlue.GetCry());

        }
        [Fact]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            
            Parrot norwrgianBlue = new ParrotNerwgian(0);
            Assert.Equal("...", norwrgianBlue.GetCry());
        }
    }
}