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
                    ""
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
                                ""
                            );
                        this.Dialog.Add
                            (
                                "Yes, this is Santa.",
                                ""
                            );
                        this.Dialog.Add
                            (
                                "You're really gullible.",
                                ""
                            );
                    }
                );
        }
    }
}