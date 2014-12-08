using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Example : Base
    {
        public Example()
            : base()
        {
            this.Dialog.Add
                (
                    "May I ask who this is?",
                    "How do you not know who I am?! I'm Nicholas's mother! @",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "My apologies, ma'am. I'm just making sure that no elves disturb Mr. Claws now.",
                                "Well, sir, I will have you know that I'm not an elf!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "I just had to double check. We know that they have some private investigator trying to get dirt on us.",
                                            "Oh, no! Well, then, patch me through to my son to see what's going on with him and the elves this time."
                                        );
                                    this.Dialog.Add
                                        (
                                            "Really? Because you sound about as dumb as a box of them. A box of elves.",
                                            "That's it! I need to speak to my son right now! @"
                                        );
                                    this.Dialog.Add
                                        (
                                            "I believe you, ma'am. You don't sound like one of those screechy little freaks.",
                                            "... Well, that's good. May I speak to my son?"
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Sorry, ma'am. I'm new to this position, and I didn't know who you were.",
                                "That's probably because all of his elven workers keep leaving due to the crappy pay!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "How do you know what their pay is?",
                                            "That's none of your business. Now let me talk to my son!"
                                        );
                                    this.Dialog.Add
                                        (
                                            "Well, maybe if they actually worked around here, they would make better pay.",
                                            "I see. Well, if it's not inconvenient, I'd like to speak to my son."
                                        );
                                    this.Dialog.Add
                                        (
                                            "Yes. They make less than me, and my pay is $2.15 an hour, plus tips.",
                                            "But... you're a secretary. How do you make tips? Whatever. Just let me talk to Santa."
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Sorry, you just sound like a loon. I guess the boss gets that from you.",
                                "WHAT IS THAT SUPPOSED TO MEAN?! @",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Exactly what it sounds like. You sound like a fruitcake made with too many nuts.",
                                            "OKAY. I WANT TO TALK TO MY SON RIGHT NOW! @"
                                        );
                                    this.Dialog.Add
                                        (
                                            "See, yelling doesn't make you sound less crazy.",
                                            "YOU'RE GOING TO REGRET SAYING THAT WHEN I TELL MY SON! @"
                                        );
                                }
                            );
                    }
                );
            this.Dialog.Add
                (
                    "Thank you for calling the North Pole. How can I help you today?",
                    "Yeah, I'd like to talk to my little Nicky?",
                    () =>
                    {
                        this.Dialog.Add
                            (
                                "I'm sorry, ma'am, but Adam Sandler doesn't work here.",
                                "Not that idiot! I mean my son! @",
                                () =>
                                { }
                            );
                    }
                );
        }
    }
}