using C63.LudumDare31.Game.Data;
namespace C63.LudumDare31.Game.Characters.Callers
{
    public class HR : Base
    {
        public static HR hrHappiness;

        public HR()
            : base()
        {
            hrHappiness = this;

            this.Dialog.Add
                (
                    "Thank you for calling the North Pole...",
                    "Put Santa on RIGHT NOW!",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "I'm sorry, but who is calling?",
                                "This is Randy from HR! I'm calling to ask why Santa decided his coal mine is going to employ toddlers?!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Probably because I gave him the idea.",
                                            "WHY WOULD YOU DO THAT?! Thanks to you, we are now facing not only lawsuits, but human rights violations!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Probably because I'm cold and heartless. Which I am, because I'm a snowman.",
                                                        "I want to speak with your supervisor RIGHT NOW!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Chill out, man. It was just a little joke.",
                                                        "Having pictures of injured toddlers leaked to the UN is not a joke! I need to speak to Santa!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I was told by Santa to say that. I wouldn't really do that.",
                                                        "Then I guess you understand how important this is! Put him on right now!"
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Probably because it's cheap labor, and he is a cheap little gnome.",
                                            "Does he not understand how much this will end up costing us?!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Well, he was dumb enough to hire someone as annoying as you. I doubt he is smart enough to grasp the situation.",
                                                        "I don't need no dumb snowman to sass me! I need you to put Santa on the line right now!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Probably enough that we could give the elves a decent living wage.",
                                                        "Oh, Rudolph! If that gets out, too... I jus tneed to talk to Santa ASAP!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm sure that he'll be very interested to know. Here, I'll patch you through.",
                                                        "About time! This is urgent!"
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh my goodness! That is horrible news! When did he decide to do this?",
                                            "I don't know, but apparently he said it was because they work better than the elves.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Oh, it's probably because they're small enough to fit through the pipes to stop the gas leaks.",
                                                        "They're dealing with gas leaks down there, too?! Patch me through right now!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "That, and you won't believe the small things that parents will sell their kids for.",
                                                        "Are you even taking this seriously?! Let me speak to Santa!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "How can they do better work when they don't even understand what's going on?",
                                                        "I don't know, but I'm about to find out."
                                                    );
                                            }
                                        );

                                }
                            );
                        this.Dialog.Add
                            (
                                "Santa doesn't accept calls from angry parents. You'll have to go through the complaints department.",
                                "This is Randy from HR! You idiot!",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Oh, good. Because we don't have a complaints department. It's just a garbage can.",
                                            "This is no time to be joking! I need to speak to Santa NOW!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "No, I'm being 100% serious. It is just a garbage can.",
                                                        "I don't have time for this nonsense! I need to speak to Santa!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Fine, I'll transfer you now.",
                                                        "Then hurry up! I'm too busy for all this lollygagging!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Lighten up, dude. You sound way too tense.",
                                                        "You're going to be tense when you don't have a job! Now get a move on!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "No need to get angry, sir. To be fair, you did sound like a complaining parent.",
                                            "Well, maybe if you would remember to save my number so you'd know it was me, we wouldn't have this problem!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "It's not my fault that Santa goes through so many secretaries. I think they get fired too quickly to get much work done.",
                                                        "Fair enough point. But I really need to speak to Santa now!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Well, maybe I will, so that way I know not to pick up the phone when you call.",
                                                        "This is ridiculously unprofessional! I want to speak to Santa!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'll get to that as soon as I can finish transfering your call.",
                                                        "See to it that you do!"
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh, I'm so sorry, Randy!",
                                            "It's okay, just please patch me through to Santa. I need to talk to him about the latest fiasco.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "What is it this time? Drugs, labor issues, or something else?",
                                                        "That is none of your business. Your job is to patch me through, not ask questions!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Please tell me he's going to lose his job. I can't stand working for this troll any longer.",
                                                        "I'm here to discuss business! Not engage in idle gossip with a secretary. Now let me talk to him.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I understand. I'll patch you through right away.",
                                                        "Good, because this could jeopardize all of our jobs if we don't hurry."
                                                    );
                                            }
                                        );
                                }
                            );
                        this.Dialog.Add
                            (
                                "Oh hey, Randy! So, what's going on this time?",
                                "You mean other than the elven labor disputes? You won't believe this. Now, he has toddlers working in the coal mines.",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Wow, that's terrible! Have any major accidents happened yet?",
                                            "Other than the twelve kids who died in a gas leak? Oh, no, that's all!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "To be fair, they are the o nly ones small enough to fit in the holes where the leaks are.",
                                                        "That doesn't help with anything! Now hurry up and let me talk to him!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "That really is terrible. I'm sure he is going to want to hear about that! Hang on.",
                                                        "He will when he hears how much the lawsuit could cost us."
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Well, at least they won't have to work for Santa anymore.",
                                                        "We won't be working for him either if they win the lawsuit. Now hurry up!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh, that's all? That's on par for Santa shenanigans.",
                                            "Yeah, but this got leaked to the U.N.'s Human Rights commission!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Is the North Pole even in their jurisdiction?",
                                                        "Well, obviously it is, or I wouldn't be telling you to let me speak to Santa!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "It's about time they paid attention to the letters I've been sending.",
                                                        "That had better be an unfunny joke, or else Santa is going to melt you after we're done talking!",
                                                        ()=>
                                                           this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Oh, wow. This will be the biggest lawsuit in the past eight months.",
                                                        "Exactly. Now let me talk to Santa about how to avoid this."
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Big deal. He treats us all like crap.",
                                            "Yeah, but your suffering won't be the cause of a $20 billion lawsuit!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Does he even have that kind of money? I figured he was poor, with the way that he pays us.",
                                                        "Glad you're more concerned with how much money he has instead of the possibility of us losing our jobes. I'll be sure to let him know you want to be fired first.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I wonder if I can get my hands on some of that money if I testify for them.",
                                                        "You should ask Santa if that will be enough for you to live on after he fires you.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Oh, crap! If he loses that, our jobs are toast. Let me patch you through!",
                                                        "'Bout time! We need to get this done with ASAP!"
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