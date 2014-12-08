using C63.LudumDare31.Game.Data;

namespace C63.LudumDare31.Game.Characters.Callers
{
    public class LaborRep : Base
    {
        public static LaborRep laborHappiness;

        public LaborRep()
            : base()
        {
            laborHappiness = this;

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
                                            "I know he's there, and you can put me through. Or tell him we're coming for him.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "So would you prefer that I threaten him for you, or put you through to his empty office?",
                                                        "SCREW YOU FROSTY! YOU CAN'T HIDE FROM THE UNION FOREVER!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Taking that kind of tone isn't going to help you with Mr. Claws.",
                                                        "You can tell Claws to think about that before he avoids the labor union for his own workers!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry that you're experiencing some difficulties with getting in contact. What can I do to help?",
                                                        "You can stop stalling, and let me talk to Santa."
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "The what now? Are you one of those LARPers?",
                                            "Larper? Wow, just wow. I've never even heard that one before. So you're making up slurs. What kind of anti-elf culture do you have up there?",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "I meant that your organization name sounds phony. When have these elves ever seen a forest? They live in the North Pole.",
                                                        "How is it their fault that globalization has taken them from their homeland?!",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Nevermind. I'll let Santa explain it to you.",
                                                        "Ugh. As much as I don't want to hear that from a trailer park gnome, I need to talk to him.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm sorry, sir. I didn't mean to be offensive. I'll put you through.",
                                                        "You need to be careful with what you say. Elves have very sensitive ears.",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "I just have nothing to say to that. I'll put you through.",
                                                                    "Well, it's about time!"
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Did you hear yourself on that one?",
                                                                    "What kind of question is that? Nevermind, just put me through.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Sir, I think you're actually being a little offensive now.",
                                                                    "What, are you going to claim I'm being an elf supremacist? I don't want to hear it. Just let me talk to Santa and get this over with.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                        }
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Oh, yes! Mr. Claws has been wanting to talk to you about firing all of the elves.",
                                            "You can't be serious?! How will his workshop run without them? He needs them!",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "He said it was the only way to comply with all of your labor demands. He'll ask them to come back on a volunteer basis, in exchange for becoming stokingholders.",
                                                        "This is inelven and completely unacceptable! Let me talk to him right now.",
                                                        ()=>
                                                            this.Emotions.Happiness--
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Mr. Claws believes that it would be in our mutual interest to replace all elves with ducks.",
                                                        "How is that in ANYONE'S best interest? What will happen to the elves?",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "Mr. Claws suggests that they should consider marrying ducks if they would like to remain in the North Pole.",
                                                                    "How does anyone in the North Pole even get married without a government?! This is ridiculous. I don't even know if I can talk sense into him, but let me try."
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "I think that sounds like somebody elven's problem to solve.",
                                                                    "Wow. It figures that a snowman would be just as cold-hearted as Claws is.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                        }
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "He is quite confident that robots will soon come along to replace the elves, and is taking a chance on that.",
                                                        "Wait, he's just taking a chance on robots being able to replace them soon?",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "Yes, sir. He's confident that next year is in fact The Future, and he'll have a cheap robot labor force before then.",
                                                                    "Okay, we're clearly dealing with a madman here. I can't even do anything with this, but I guess I have to try.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Sir, I just answer the phones. It's not even any of my business.",
                                                                    "Wouldn't it be your business if you lose your job because this lunatic can't pay the bills? Just let me talk to him.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Are you some kind of luddite? Or maybe a robo-hater?",
                                                                    "What? Robots aren't a protected class. Elves should be! Let me see if I can't convince him to show some empathy.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
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
                    "North Pole. How may I help you?",
                    "Am I speaking to an elf?",
                    ()=>
                    {
                        this.Dialog.Add
                            (
                                "Is that a proper question to ask?",
                                "What?! I mean, yes! Because I'm an elf labor representative! So, are you an elf?",
                                ()=>
                                {
                                    this.Dialog.Add
                                        (
                                            "Does it really matter?",
                                            "Okay, I get it. You may not want to answer that question because of the persecution. Maybe Mr. Claws doesn't even know. However, you have to help me out here.",
                                            ()=>
                                            {
                                                this.Dialog.Add
                                                    (
                                                        "Are you asking me to risk my job for you?",
                                                        "Isn't it worth it, to help your fellow elf? You may not be first to go now, but one day, you will be!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Sir, would you believe that I may get killed for this?",
                                                        "We all have to make sacrifices. Please, it's for the greater good."
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Maybe you could do a little something to help me care. I do work for gratuities.",
                                                        "Did you just suggest that I BRIBE you?",
                                                        ()=>
                                                        {
                                                            this.Dialog.Add
                                                                (
                                                                    "Sir, it's part of my pay. Do you care about laborers, or not?",
                                                                    "This is outrageous. Santa can't seriously be doing this. Let me talk to him.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Sorry, hard times. I'm sure you understand.",
                                                                    "Stop aiding the oppressor here, and let me through!",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Sorry! I don't want to get in trouble... Except, I would get in trouble with nobody, because there are no laws in the North Pole.",
                                                                    "You know, I really hate all of you. But I have to talk to Santa. NOW.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                        }
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Maybe. So where's my help?",
                                            "Ugh, you sound just like him. One of you is bad enough, so just patch me through to Claws, now.",
                                            ()=>
                                                this.Emotions.Happiness--
                                        );
                                }
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
                                                                    "Okay, I may not be an elf, but I know what I'm talking about. Elves are a very healthy people, but someone has to look out for their rights. That's why I need to talk to Santa.",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                            this.Dialog.Add
                                                                (
                                                                    "Great, then I'm sure they'll have many more happy years of working for Mr. Claws.",
                                                                    "Not if I have anything to do with it! I mean, it won't be happy for Santa. I want to it to be happy for the elves. Just put me through!",
                                                                    ()=>
                                                                        this.Emotions.Happiness--
                                                                );
                                                        }
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "Sir, I assure you, Mr. Claws is a very busy gnome.",
                                                        "Too busy to take care of his workforce? He won't be busy much longer, if that's true!"
                                                    );
                                                this.Dialog.Add
                                                    (
                                                        "I'm not really paid to care what the reason is. I just have to answer the calls.",
                                                        "Oh, I'm so sorry. I wasn't thinking of how bad things must be for you, too. I'll do what I can to make it easy on you, if you just put me through now.",
                                                        ()=>
                                                            this.Emotions.Happiness++
                                                    );
                                            }
                                        );
                                    this.Dialog.Add
                                        (
                                            "Making all the toys himself, because the elves are too lazy to do a good job.",
                                            "OH MY GOODNESS. Okay, just put me through. I'm so done.",
                                            ()=>
                                                this.Emotions.Happiness--
                                        );
                                    this.Dialog.Add
                                        (
                                            "Sir, I'm not supposed to answer that question.",
                                            "Oh, right. A Santa sympathizer. Of course that's what he'd employ.",
                                            ()=>
                                                this.Emotions.Happiness--
                                        );
                                }
                            );
                    }
                );
        }
    }
}