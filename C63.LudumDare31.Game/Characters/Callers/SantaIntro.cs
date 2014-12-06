using C63.LudumDare31.Game.Data;
using C63.LudumDare31.Game.Characters.Callers;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Example : Base
    {
        public Example()
            : base()
        {

            if (duckCall == true)
            {
                this.Dialog.Add
                    (
                        "Mr. Claws?",
                        "Hey, uh... I had a really tough night, you know, making toys and whatnot, and I ain't feeling so great this morning. Ya'll mind keeping the calls to a minimum?",
                        ()=>
                            {
                                this.Dialog.Add
                                    (
                                        "Yes, sir!",
                                        "Ya'll a lot better at this job than that last guy. Made everybody what callt us up mad with his \"Aaye!\" and \"Nam-mary\" kinder talk. Folks thought we was using some foreign call center and callt us un-Merican misers and said we ain't Christian. Really ruint the holiday -- I mean Christmas -- mood, you know what I'm sayin'?",
                                        ()=>
                                            {}
                                    );
                                this.Dialog.Add
                                    (
                                        "Which calls should I allow through?",
                                        "Is you even got anything but snow in that head a yours? What 'm I payin' ya'll $2.15 and tips an hour for if ya'll ain't know'd this stuff?",
                                        ()=>
                                            {}
                                    );
                            }
                     );
            }

            else
            {
                this.Dialog.Add
                    (
                        "Hello, um... Santa?",
                        "WHY DID SOME GOLLDANG DUCK CALL ME?!",
                        ()=>
                        {
                            this.Dialog.Add
                                (
                                    "Did you not want that, or...?",
                                    "Ain't nobody can understand them! NO MORE DUCK CALLS!",
                                    () =>
                                    {}
                                );
                        }
                     );
            }
        }
    }
}
