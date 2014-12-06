using C63.LudumDare31.Game.Data; // Not needed, but makes it so you don't have to add Data before every Question and Answer.

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Example : Base
    {
        public Example()
            : base()
        {
            // You can create a Question and Answer in a variety of ways.  These ways can also be mixed.

            this.Dialog.Add
            (
                new Question(() => "..?"),
                new Answer(() => "..!")
            );

            this.Dialog.Add
            (
                () => "..?",
                () => "..!"
            );

            this.Dialog.Add
            (
                "..?",
                "..!"
            );

            Question question = new Question("..?");
            Answer answer = new Answer("..!");

            this.Dialog.Add
            (
                question,
                answer
            );

            // Here is an example of a simple dialog tree.

            this.Dialog.Add
            (
                "Who is calling?",
                () =>
                {
                    this.Dialog.Add
                    (
                        "What are you calling about?",
                        () =>
                        {
                            this.Dialog.Add
                            (
                                "Alright, please hold.",
                                () =>
                                {
                                    return "Thank you.";
                                }
                            );

                            this.Dialog.Add
                            (
                                "Sorry, my boss can not be disturbed right now.",
                                () =>
                                {
                                    return "But I really need to speak to your boss!";
                                }
                            );

                            return "I'd like to speak to your boss.";
                        }
                    );

                    return "This is Example.";
                }
            );
        }
    }
}
