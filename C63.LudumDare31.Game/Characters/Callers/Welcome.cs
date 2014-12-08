using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class Welcome : Base
    {
        public Welcome()
            : base()
        {
            this.OnDisconnect += this.Disconnected;

            this.Dialog.Add
            (
                "Hello?",
                "Mae govannen! This is Ciron, first counsel of the North Pole. As a new Ambassador and Liason for Lord Claws, it is your job to keep him pleased by diligently screening all of his callers. You must use your own good judgment as a Creature of the North to determine who is worthy to speak to the Bearded One in this trying time of Winter Solstice. Quel marth!"
            );
        }

        void Disconnected(bool hold)
        {
            if(hold)
            {
                return;
            }

            Game.Callers.Remove(this);
            Game.Callers.Add(new Characters.Callers.IntroDuckTion());
        }
    }
}
