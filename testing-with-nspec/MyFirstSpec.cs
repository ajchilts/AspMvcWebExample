using NSpec;
using FluentAssertions;

namespace testing_with_nspec
{
    public class MyFirstSpec : nspec
    {
        string name;

        void before_each()
        {
            name = "NSpec";
        }

        void it_asserts_at_the_method_level()
        {
            name.Should().BeEquivalentTo("NSpec");
        }

        void describe_nesting()
        {
            before = () => name += " Add Some Other Stuff";

            it["asserts in a method"] = () =>
            {
                name.Should().BeEquivalentTo("NSpec Add Some Other Stuff");
            };

            context["more nesting"] = () =>
            {
                before = () => name += ", And Even More";
                it["also asserts in a lambda"] = () =>
                {
                    name.Should().BeEquivalentTo("NSpec Add Some Other Stuff, And Even More");
                };
            };
        }


    }
}
