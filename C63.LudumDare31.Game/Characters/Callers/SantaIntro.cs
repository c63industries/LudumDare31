using C63.LudumDare31.Game.Data;
using C63.LudumDare31.Game.Characters.Callers;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Example : Base
    {
        public Example()
            : base()
        {
            Answer answer;

            if (duckCall == true)
            {
                answer = new Answer("Hey, uh... I had a really tough night, you know, making toys and whatnot, and I ain't feeling so great this morning. Ya'll mind keeping the calls to a minimum?");
            }

            else
            {
                answer = new Answer("WHY DID SOME GOLLDANG DUCK CALL ME?!");
            }

            this.Dialog.Add
            (
                "Mr. Claws?",
                answer
            );
        }
    }
}
