using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeChallenges.Code_Challenge_13;

namespace CodeChallengesTest
{
    public class Test13
    {

        [Fact]
        public void Test1()
        {

            Assert.True(Code_Challenge_13.ValidateBrackets("{{}}"));
            Assert.True(Code_Challenge_13.ValidateBrackets("()()"));
            Assert.True(Code_Challenge_13.ValidateBrackets("[[]]"));

        }

        [Fact]
        public void MixedBracketTest()
        {

            Assert.True(Code_Challenge_13.ValidateBrackets("(()[]{})[]"));
            Assert.True(Code_Challenge_13.ValidateBrackets("[]{}"));
            Assert.True(Code_Challenge_13.ValidateBrackets("{{(({}}}))"));

        }

        [Fact]
        public void FailCases()
        {

            Assert.False(Code_Challenge_13.ValidateBrackets("{"));
            Assert.False(Code_Challenge_13.ValidateBrackets("}}[[]{"));
            Assert.False(Code_Challenge_13.ValidateBrackets("{}{}[][]]]]]"));

        }
    }
}
