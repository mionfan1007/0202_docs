using docum_dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docum_test
{
    public class Testing
    {
        ListMethods<string> methods = new ListMethods<string>();

        [Fact]
        public void ContainsValueInList_True()
        {
            methods.AddElement("hello");
            List <string> values = methods.GetList();
            Assert.True(values.Contains("hello"));   
            
        }

        [Fact]
        public void ContainsValueInList_False()
        {
            methods.AddElement("hello_2");
            List<string> values = methods.GetList();
            Assert.False(values.Contains("goodbye"));

        }

        [Fact]
        public void ContainsValueInList_Removed()
        {
            methods.AddElement("hello");
            methods.RemoveElement("hello");
            List<string> values = methods.GetList();
            Assert.False(values.Contains("hello"));

        }
        [Fact]
        public void ContainsValueInList_Removed_NotAdded()
        {
            methods.AddElement("hello");
            methods.RemoveElement("hello_2");
            List<string> values = methods.GetList();
            Assert.True(values.Contains("hello"));

        }
        [Fact]
        public void Search_Contains_True()
        {
            methods.AddElement("hello");
            string a = methods.SearchElement("hello");
            string e = "hello";
            List<string> values = methods.GetList();
            Assert.Equal(e,a);

        }
        [Fact]
        public void Search_Contains_False()
        {
            methods.AddElement("hello_2");
            string a = methods.SearchElement("hello");
            string e = "hello";
            List<string> values = methods.GetList();
            Assert.NotEqual(e,a);

        }
    }
}
