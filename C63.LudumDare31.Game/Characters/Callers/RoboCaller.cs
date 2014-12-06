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
                "Hello. This is robot. Please press 1 to continue."
            );
        }
    }
}
