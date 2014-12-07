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
                    "Thank you for calling the North Pole. How may I help you?",
                    "HELLO?! Is this my little Nicky Wicky?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "Ma'am, I believe you have the wrong number.",
                                "This is my son's number! Who the hell are you?!",
                                () =>
                                {
                                    this.Dialog.Add
                                        (
                                        "Oh my gosh! Ma'am, I'm so sorry.",
                                        "You're darn right you're sorry! You smurfy men always have an uppity attitude. Keeps my little Nicky from calling me."
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh, like mother, like son. You're both idiots.",
                                            "WHAT DID YOU JUST SAY TO ME?!"
                                        );
                                    this.Dialog.Add
                                        (
                                            "I apologize, ma'am.",
                                            "What the hell is my son paying you for?!"
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Ma'am, are you talking about Mr. Claws?",
                                "Yes, my son! Are you one of those gnomes that he hires?",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "No, ma'am. I'm a snowman, not an elf.",
                                            "Oh, good. I can't stand those money-grubbing little dwarves. May I talk to my son?",
                                            ()=>
                                                {}
                                        );
                                    this.Dialog.Add
                                        (
                                            "Does it matter, ma'am?",
                                            "Oh, no. You just have that squeaky sound them little fellers do.",
                                            ()=>
                                            { }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Yes, ma'am, with a pointy little green hat and everything.",
                                            "Oh, let me tell you. You are SO lucky to be in my son's employment. I hear he treats your kind really well.",
                                            ()=>
                                            { }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Ah, you must be the delightful Mama Claws that I've heard so much about!",
                                "Why, aren't you a flatterer! You're so much better than that last snowhead he had!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Ma'am, I think you're referring to me, because I'm the only snowman he's employed.",
                                            "Don't you lie to me! I know what my son does!",
                                            ()=>
                                            { }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Ma'am, that's actually very insensitive.",
                                            "I know you guys call each other that, so why can't I say it?",
                                            ()=>
                                            { }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Well, I hope to be around longer than he was.",
                                            "As long as you don't act like those greedy little smurfs, you'll be fine!",
                                            ()=>
                                            { }
                                        );
                                }
                            );
                    }
                );
        }
    }
}