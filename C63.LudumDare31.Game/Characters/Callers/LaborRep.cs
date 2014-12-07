using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class LaborRep : Base
    {
        public LaborRep()
            : base()
        {
            this.Dialog.Add
                (
                    "Hello from the North Pole, home of Santa's happy elves!",
                    "You must be joking.",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "No, this is the North Pole. How may I help you?",
                                "I know where I'm calling. I'm a representative for The Council of Sylvan Artisans.",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "I'm sure Mr. Claws would love to talk to you, but he's out. May I take a message?",
                                            ""
                                        );
                                }
                            );
                    }
                );
            this.Dialog.Add
                (
                    "North Pole. How may I help you?",
                    "Am I speaking to an elf?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "Is that a proper question to ask?",
                                ""
                            );
                        this.Dialog.Add
                            (
                                "How did you know?",
                                "It figures that Santa would have you answering the phones for him. Where is he?",
                                () =>
                                {
                                    this.Dialog.Add
                                        (
                                            "He's out. May I take a message?",
                                            "Oh, of course he is. Either hiding or shirking his responsibility.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Could those be considered the same thing?",
                                                        "There's no need to be that way. Tell him that I'm a representative of The Council of Sylvan Artisans, and he can't hide from us forever. Elves live a long time.",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "Is that true? I thought it was a stereotype that caused devaluation of elves' time.",
                                                                    "Okay, I may not be an elf, but I know what I'm t"
                                                                );
                                                        }
                                                    );
                                            }
                                        );
                                }
                            );
                    }
                );
        }
    }
}