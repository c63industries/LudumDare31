using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class RoboCaller : Base
    {
        public RoboCaller()
            : base()
        {

            this.Dialog.Add
            (
                "North Pole.",
                "Hello. This is robot. Please press 1 to continue.",
                ()=>
                {
                    this.Dialog.Add
                        (
                            "1",
                            "I am calling to speak to Santa Claws. If he is available, please press 1. If he is unavailable, please press 2.",
                            ()=>
                            {
                                this.Dialog.Add
                                    (
                                        "1",
                                        "Answer unacceptable. I must communicate with Santa Claws. To comply with this request, please press 1.",
                                        () =>
                                        {

                                        }
                                    );
                            }
                        );
                    }
            );
        }
    }
}
