using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Four20 : Base
    {
        public Four20()
            : base()
        {
            this.Dialog.Add
                (
                    "Hello, this is dog.",
                    "Wow, wait. Are you serious? Am I talking to dog right now?",
                    ()=>
                    {
                        this.Dialog.Add
                        (
                            "Yes.",
                            "Wow. Santa has given us talking dogs. He can truly do anything."
                        );
                    }
                );
            this.Dialog.Add
                (
                    "North Pole. Santa isn't in right now. How may I help you?",
                    "Um... catnip?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "Did you call Santa to ask for catnip?",
                                "Mrs. Claws said I could.",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "I really doubt that.",
                                            "Meow?"
                                        );
                                }
                            );
                    }
                );
            this.Dialog.Add
                (
                    "Ho, ho, ho! Merry Christmas!",
                    "Wow, wait. Are you serious? Am I talking to Santa right now?",
                    () =>
                    {
                        this.Dialog.Add
                            (
                                "Are YOU serious? You're the one that called the North Pole.",
                                "I don't, um... so, what can your establishment, you know... give me for Christmas?",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "I'm not at liberty to disclose Mr. Claws' Christmas plans.",
                                            "Oh, crap... Well, uh, Mrs. Claws said I could call...?",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Ma'am, I have no idea what that means. Mrs. Claws doesn't talk.",
                                                        "Oooohhhh... can I still get the catnip?"
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Yes, this is Santa.",
                                "WOW! HEY, EVERYBODY, I'M TALKING TO SANTA!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Ma'am, please don't shout into the phone.",
                                            "Oh, I am SOOOOOO sorry. Heheheheheh.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Can I help you with something?",
                                                        "Mrs. Claws said to tell you... meow.",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "Ma'am, that doesn't mean anything to me.",
                                                                    "Ohhh... Can I speak to Santa?",
                                                                    ()=>
                                                                    {
                                                                        this.Dialog.Add
                                                                            (
                                                                                "Mr. Claws doesn't like to be disturbed.",
                                                                                "Wowwwww... I don't know what to do. Can I just like, ask him that?"
                                                                            );
                                                                    }
                                                                );
                                                        }
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "You're really gullible.",
                                "Gullible? Well, can I tell you about what Mrs. Claws told me?",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Ma'am, I don't think Mrs. Claws can talk.",
                                            "She told me to call you about the catnip. Ask Santa for more catnip.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "That's really not a priority to bother Santa with, is it?",
                                                        "It is to me! Please. Please, please, please. I want to talk to Santa! Meow!"
                                                    );
                                            }
                                        );
                                }
                            );
                    }
                );
        }

        void Transferred()
        {
            Game.Boss.Emotions.Happiness++;
        }
    }
}