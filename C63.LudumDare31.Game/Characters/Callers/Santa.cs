using C63.LudumDare31.Game.Data;
using C63.LudumDare31.Game.Characters.Callers;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Santa : Base
    {
        public Santa()
            : base()
        {
            this.OnConnect += this.Connected;

            this.Emotions.OnHappiness += this.OnHappiness;
        }

        private new void Connected()
        {
            Game.Callers.Add(new Characters.Callers.Grandma());
            Game.Callers.Add(new Characters.Callers.GrandmaPI());
            Game.Callers.Add(new Characters.Callers.HR());
            Game.Callers.Add(new Characters.Callers.LaborRep());
            Game.Callers.Add(new Characters.Callers.Safety());
        }

        public void OnDuck(bool transfered)
        {
            Game.Callers.Add(this);

            if (transfered)
            {

                this.Dialog.Add
                    (
                        "Hello, um... Santa?",
                        "WHY DID SOME ANGRY DUCK CALL ME?!",
                        () =>
                        {
                            this.Dialog.Add
                                (
                                    "Did you not want that, or...?",
                                    "Ain't nobody can understand them! NO MORE DUCK CALLS!",
                                    () =>
                                    {
                                        this.Emotions.Happiness--;
                                    }
                                );
                        }
                     );
            }
            else
            {
                this.Dialog.Add
                    (
                        "Mr. Claws?",
                        "Hey, uh... I had a really tough night, you know, making toys and whatnot, and I ain't feeling so great this morning. Ya'll mind keeping the calls to a minimum?",
                        () =>
                        {
                            this.Dialog.Add
                                (
                                    "Yes, sir!",
                                    "Ya'll a lot better at this job than that last guy. Made everybody what callt us up mad with his elvie kinder talk. Folks thought we was using some foreign call center and callt us un-Merican misers and said we ain't Christian. Really ruint the holiday -- I mean Christmas -- mood, you know what I'm sayin'?"
                                );
                            this.Dialog.Add
                                (
                                    "Which calls should I allow through?",
                                    "Is you even got anything but snow in that head a yours? What 'm I payin' ya'll $2.15 and tips an hour for if ya'll ain't know'd this stuff?",
                                    () =>
                                    {
                                        this.Dialog.Add
                                            (
                                                "Sir, that's not necessary.",
                                                "You ain't in no position to tell Santa Claws what's necessary! Your job is to shut up and listen!",
                                                () =>
                                                {
                                                    this.Dialog.Add
                                                        (
                                                            "I thought my job was to screen your calls.",
                                                             "Your job is what I tell you! Now don't bother me unless I need bothered!"
                                                        );
                                                    this.Dialog.Add
                                                        (
                                                            "I thought my job was to tell you to kiss my frozen white ass.",
                                                            "Well it's about to melt, because you gonna get fired!",
                                                            () =>
                                                            {
                                                                this.Emotions.Happiness--;
                                                            }
                                                        );
                                                }
                                            );
                                    }
                                );
                            this.Dialog.Add
                                (
                                    "Did you really? I thought the elves were making the toys. Are you okay?",
                                    "I've been Santa Claws longer than you've been alive, don't you tell me what! I'm busy, now just keep anyone from callin' until I get better!"
                                );
                        }
                     );
            }
        }

        void OnHappiness(sbyte value)
        {
            if (value > -3)
            {
                return;
            }

            Game.End();
        }
    }
}
