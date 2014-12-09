using C63.LudumDare31.Game.Data;
namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Safety : Base
    {
        public static Safety safetyHappiness;

        public Safety()
            : base()
        {
            safetyHappiness = this;

            this.Dialog.Add
                (
                    "North Pole, how may I direct your call?",
                    "We have a safety issue with the boiler room. Can you patch me through to Santa?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "What appears to be the issue, ma'am?",
                                "There are dead elves clogging up the ventilation to the boiler room. I'm sure you can figure out how this poses multiple issues.",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "That does sound like a potential lawsuit. Let me put your call through to my boss.",
                                            "That's wise."
                                        );
                                    this.Dialog.Add
                                        (
                                            "How the hell did that happen?!",
                                            "They keep trying to escape through the ventiliation shafts. We have to do something to assure this doesn't continue happening.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry, ma'am, but is this really something to bother Santa with?",
                                                        "Do you have snow in your ears?! This is a big deal!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "That's disgusting. Let me just put you through to Santa.",
                                                        "Thank you."
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Who is this?",
                                "This is the Health and Safety Supervisor, you big dumb snowcone!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "My boss has been receiving a lot of annoying calls recently. Are you sure this is important enough to disturb him with?",
                                            "Damn right, it's important! Unless you want to get fired when your boss gets sued for a wad of dead elves crammed in the ventilation shaft!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Ma'am, I only make $2.15 plus tips an hour. But I guess it's better than nothing.",
                                                        "Just get your boss on the phone.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm having a hard time seeing how this is worth me angering Mr. Claws over. Can't you deal with it?",
                                                        "Alright, it's your future when the whole office stinks like elves."
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "I'm sorry, ma'am. Let me patch you through.",
                                            "Make it quick. This is a safety emergency."
                                        );
                                }
                            );
                    }
                );
        }

        void Disconnected(bool hold)
        {
            if (hold)
            {
                return;
            }

            Game.Boss.Emotions.Happiness--;
        }
    }
}