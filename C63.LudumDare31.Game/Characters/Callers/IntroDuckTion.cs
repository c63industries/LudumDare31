using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class IntroDuckTion : Base
    {
        public static IntroDuckTion duckHappiness;

        public IntroDuckTion()
            : base()
        {
            duckHappiness = this;

            this.Dialog.Add
            (
                "North Pole, how may I help you?",
                "Quack!",
                ()=>
                {
                    this.Dialog.Add
                        (
                            "What?",
                            "QUACK!"
                        );

                    Answer answer = new Answer(() =>
                            {
                                this.Dialog.Add
                                (
                                    "Would you like to speak to Mr. Claws?",
                                    "Quack.",
                                    ()=>
                                    {
                                        this.Dialog.Add
                                            (
                                                "I'm sorry, I can't put a duck through to my boss.",
                                                "QUUUUUUUUUAAAACK",
                                                ()=>
                                                {
                                                    this.Dialog.Add
                                                        (
                                                            "I have to hang up now.",
                                                            "Quackquackquack!",

                                                            ()=> this.Emotions.Happiness--
                                                        );
                                                }
                                            );
                                        this.Dialog.Add
                                            (
                                                "Okay, I'll put you through.",
                                                "Quackquack.",

                                                () => this.Emotions.Happiness++
                                            );
                                    }
                                );
                                return "QUACKQUACKQUACKQUACKQUACK";
                            }
                    );

                    this.Dialog.Add
                        (
                            "Is this a duck?",
                            answer 
                        );
                    this.Dialog.Add
                        (
                            "What's wrong with your voice?",
                            answer
                        );
                }

            );
        }
    }
}
