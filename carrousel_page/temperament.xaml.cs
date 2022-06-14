using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace carrousel_page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class temperament : CarouselPage
    {
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        Button Btn;
        Label lbl;
        protected override void OnAppearing()
        {
            lbl.Text = Preferences.Get("result", "");
            base.OnAppearing();
        }
        public void chtx()
        {
            Preferences.Set("result", $"your temperament:\n Phlegmatic:{(A * 100) / 13}%\n Melancholic:{(B * 100) / 13}%\n Choleric:{(C * 100) / 13}%\n Sanguine:{(D * 100) / 13}%");
            lbl.Text = $"your temperament:\n Phlegmatic:{(A * 100) / 13}%\n Melancholic:{(B * 100) / 13}%\n Choleric:{(C * 100) / 13}%\n Sanguine:{(D * 100) / 13}%";
        }
        public async void Result()
        {

                if (A == 13 || A > B && A > C && A > D)
                {
                    await DisplayActionSheet("Ты флегматик", "OK", null);
                    A = 0;
                    B = 0;
                    C = 0;
                    D = 0;
                }
                else if (B == 13 || B > A && B > C && B > D)
                {
                    await DisplayActionSheet("Ты меланхолик", "OK", null);
                    A = 0;
                    B = 0;
                    C = 0;
                    D = 0;
                }
                else if (C == 13 || C > A && C > B && C > D)
                {
                    await DisplayActionSheet("Ты холерик", "OK", null);
                    A = 0;
                    B = 0;
                    C = 0;
                    D = 0;
                }
                else if (D == 13 || D > A && D > B && D > C)
                {
                    await DisplayActionSheet("Ты сангвиник", "OK", null);
                    A = 0;
                    B = 0;
                    C = 0;
                    D = 0;
                }
            else
            {
                await DisplayActionSheet("error", "OK", null);
            }

        }
        public async void Test()
        {

            string q1 = await DisplayActionSheet("Какой у вас характер?", "Cancel", null, "спокойный, обстоятельный, миролюбивый", "Робкий, застенчивый, обидчивый", "Энергичный, неугомонный, шаловливый", "Жизнелюбивый, оптимистичный, компромиссный");
            if (q1 == "спокойный, обстоятельный, миролюбивый")
            {
                A+=1;
            }
            else if (q1 == "Робкий, застенчивый, обидчивый")
            {
                B+=1;
            }
            else if (q1 == "Энергичный, неугомонный, шаловливый")
            {
                C+=1;
            }
            else if (q1 == "Жизнелюбивый, оптимистичный, компромиссный")
            {
                D+=1;
            }
            if (q1 != "Cancel")
            {
                string q2 = await DisplayActionSheet("Какие эмоции вы наиболее часто испытываете?", null, null, "положительные, бурных реакций нет", "Страх", "Гнев, бурные эмоции", "Положительные эмоции, много смеюсь");
                if (q2 == "положительные, бурных реакций нет")
                {
                    A += 1;
                }
                else if (q2 == "Страх")
                {
                    B += 1;
                }
                else if (q2 == "Гнев, бурные эмоции")
                {
                    C += 1;
                }
                else if (q2 == "Положительные эмоции, много смеюсь")
                {
                    D += 1;
                }
                string q3 = await DisplayActionSheet("Какие игры вам нравятся?", null,null, "уединенные, тихие, спокойные", "подвижные и шумные – только с близкими", "азартные, шумные, даже агрессивные", "всякие, но чтобы было весело");
                if (q3 == "уединенные, тихие, спокойные")
                {
                    A += 1;
                }
                else if (q3 == "подвижные и шумные – только с близкими")
                {
                    B += 1;
                }
                else if (q3 == "азартные, шумные, даже агрессивные")
                {
                    C += 1;
                }
                else if (q3 == "всякие, но чтобы было весело")
                {
                    D += 1;
                }
                string q4 = await DisplayActionSheet("Как реагируете на наказание?", null,null, "практически без эмоций", "негативно, с обидой", "на словесные – спокойно, на другие...", "спокойно");
                if (q4 == "практически без эмоций")
                {
                    A += 1;
                }
                else if (q4 == "негативно, с обидой")
                {
                    B += 1;
                }
                else if (q4 == "на словесные – спокойно, на другие...")
                {
                    C += 1;
                }
                else if (q4 == "спокойно")
                {
                    D += 1;
                }
                string q5 = await DisplayActionSheet("Как ведете себя в неожиданных ситуациях?", null,null, "малоэмоционально", "пытаюсь избежать этой ситуации", "пытаюсь сопротивляться", "проявляю любопытство");
                if (q5 == "малоэмоционально")
                {
                    A += 1;
                }
                else if (q5 == "пытаюсь избежать этой ситуации")
                {
                    B += 1;
                }
                else if (q5 == "пытаюсь сопротивляться")
                {
                    C += 1;
                }
                else if (q5 == "проявляю любопытство")
                {
                    D += 1;
                }
                string q6 = await DisplayActionSheet("Насколько вы общительны?", null,null, "предпочитаю уединение", "общителен только с близкими", "нуждаюсь в зрителях и сподвижниках", "люблю общество и знакомлюсь быстро");
                if (q6 == "предпочитаю уединение")
                {
                    A += 1;
                }
                else if (q6 == "общителен только с близкими")
                {
                    B += 1;
                }
                else if (q6 == "нуждаюсь в зрителях и сподвижниках")
                {
                    C += 1;
                }
                else if (q6 == "люблю общество и знакомлюсь быстро")
                {
                    D += 1;
                }
                string q7 = await DisplayActionSheet("Какое положение вы занимаете среди сверстников?", null,null, "авторитета и качеств лидера не имею", "не лидер, авторитет имею в узком кругу друзей", "сам себя выдвигаю лидером,awooga", "прирожденный лидер, душа компании");
                if (q7 == "авторитета и качеств лидера не имею")
                {
                    A += 1;
                }
                else if (q7 == "не лидер, авторитет имею в узком кругу друзей")
                {
                    B += 1;
                }
                else if (q7 == "сам себя выдвигаю лидером,awooga")
                {
                    C += 1;
                }
                else if (q7 == "прирожденный лидер, душа компании")
                {
                    D += 1;
                }
                string q8 = await DisplayActionSheet("Особенности памяти", null,null, "Запоминаю медленно, но почти не забываю целое", "запоминаю по-разному, больше вникаю в мелочи", "быстро запоминаю детали, но быстро забываю", "быстро и легко схватываю целое и долго помню");
                if (q8 == "Запоминаю медленно, но почти не забываю целое")
                {
                    A += 1;
                }
                else if (q8 == "запоминаю по-разному, больше вникаю в мелочи")
                {
                    B += 1;
                }
                else if (q8 == "быстро запоминаю детали, но быстро забываю")
                {
                    C += 1;
                }
                else if (q8 == "быстро и легко схватываю целое и долго помню")
                {
                    D += 1;
                }
                string q9 = await DisplayActionSheet("Утомляемость:", null,null, "мочень низкая, почти не устаю", "высокая, любая деятельность вызывает упадок сил", "иногда средняя, а иногда высокая, зависит от моих эмоций", "средняя, устаю соразмерно деятельности");
                if (q9 == "очень низкая, почти не устаю")
                {
                    A += 1;
                }
                else if (q9 == "высокая, любая деятельность вызывает упадок сил")
                {
                    B += 1;
                }
                else if (q9 == "иногда средняя, а иногда высокая, зависит от моих эмоций")
                {
                    C += 1;
                }
                else if (q9 == "средняя, устаю соразмерно деятельности")
                {
                    D += 1;
                }
                string q10 = await DisplayActionSheet("Особенности речи:", null,null, "медленная, без жестов", "тихая и неуверенная", "речь эмоциональная, отрывистая, быстрая", "с жестами и мимикой, выразительная");
                if (q10 == "медленная, без жестов")
                {
                    A += 1;
                }
                else if (q10 == "тихая и неуверенная")
                {
                    B += 1;
                }
                else if (q10 == "речь эмоциональная, отрывистая, быстрая")
                {
                    C += 1;
                }
                else if (q10 == "с жестами и мимикой, выразительная")
                {
                    D += 1;
                }
                string q11 = await DisplayActionSheet("Движения:", null,null, "неторопливые, нерасторопные", "неторопливые, нерасторопные", "резкие, порывистые", "резкие, порывистые");
                if (q11 == "неторопливые, нерасторопные")
                {
                    A += 1;
                }
                else if (q11 == "неторопливые, нерасторопные")
                {
                    B += 1;
                }
                else if (q11 == "резкие, порывистые")
                {
                    C += 1;
                }
                else if (q11 == "с жестами и мимикой, выразительная")
                {
                    D += 1;
                }
                string q12 = await DisplayActionSheet("Привыкание к новому месту", null,null, "боязнь нового, нежелание перемен", "долгое привыкание, трудная адаптация", "легкое привыкание к новой обстановке", "адаптация легкая и быстрая");
                if (q12 == "боязнь нового, нежелание перемен")
                {
                    A += 1;
                }
                else if (q12 == "долгое привыкание, трудная адаптация")
                {
                    B += 1;
                }
                else if (q12 == "легкое привыкание к новой обстановке")
                {
                    C += 1;
                }
                else if (q12 == "адаптация легкая и быстрая")
                {
                    D += 1;
                }
                string q13 = await DisplayActionSheet("Особенности сна:", null,null, "засыпаю быстро, сплю спокойно, состояние после сна вялое", "укладываюсь спать долго, но засыпаю быстро", "асыпаю долго и трудно, сон беспокойный", "засыпаю быстро, сон крепкий");
                if (q13 == "засыпаю быстро, сплю спокойно, состояние после сна вялое")
                {
                    A += 1;
                }
                else if (q13 == "укладываюсь спать долго, но засыпаю быстро")
                {
                    B += 1;
                }
                else if (q13 == "асыпаю долго и трудно, сон беспокойный")
                {
                    C += 1;
                }
                else if (q13 == "засыпаю быстро, сон крепкий")
                {
                    D += 1;
                }
                chtx();
                Result();

            }

        }

        public temperament ()
        {
            Btn = new Button
            {
                Text = "What's your temperament?",
                BackgroundColor = Color.Bisque,
                TextColor = Color.White,
                WidthRequest = 300,
                HeightRequest = 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Btn.Clicked += Btn_Clicked;
            lbl = new Label
            {
                Text = "",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
            
            var Sanguine = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {   Text="Sanguine",
                            FontSize=Device.GetNamedSize(NamedSize.Large,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center},
                        lbl,
                        new BoxView
                        {   Color=Color.LightGoldenrodYellow,
                            WidthRequest=400,
                            HeightRequest=50,
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.StartAndExpand},
                        lbl,
                        new Image
                        {
                            Source="sangvinik.PNG"
                        },
                        new Label
                        {
                            Text="ABOUT\nPeople with a sanguine personality type tend to be lively, optimistic, buoyant, and carefree. They love adventure and have high risk tolerance. Sanguine people are typically poor at tolerating boredom and will seek variety and entertainment.",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            var Choleric = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {   Text="Choleric",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center},
                        new BoxView
                        {   Color=Color.PaleVioletRed,
                            WidthRequest=400,
                            HeightRequest=50,
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.StartAndExpand},
                        new Image
                        {
                            Source="holerik.PNG"
                        },
                        new Label
                        {
                            Text="ABOUT\nCholeric people are the leaders of the group. They are quick-thinkers, effective influencers, competitive, independent, easily annoyed, and prideful. They are highly engaged and intentional in anything they do, be it at work or even during conversations.",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        }

                    }
                }
            };
            var Melancholic = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {   Text="Melancholic",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center},
                        new BoxView
                        {   Color=Color.CadetBlue,
                            WidthRequest=400,
                            HeightRequest=50,
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.StartAndExpand},
                        new Image
                        {
                            Source="melanholik.PNG"
                        },
                        new Label
                        {
                            Text="ABOUT\nPeople with melancholic temperament are usually thin and have a small frame. They don't have much big body parts and they don't gain weight. They have a dark complexion and are likely to develop dark spots on their skin. Their skin is dry and rough and is prone to get wrinkles and show signs of premature skin aging.",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            var Phlegmatic = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {   Text="Phlegmatic",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center},
                        new BoxView
                        {   Color=Color.BlueViolet,
                            WidthRequest=400,
                            HeightRequest=50,
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.StartAndExpand},
                        new Image
                        {
                            Source="flegmatik.PNG"
                        },
                        new Label
                        {
                            Text="ABOUT\nPeople with a phlegmatic personality are very agreeable. – Phlegmatics could be described as cooperative, considerate, charitable, sympathetic, trusting, and warm. They like to express their feelings, sometimes dramatizing their experience, which is the evidence of high estrogen activity.",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            var startpage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {   Text="Temperaments",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        },
                        lbl,
                        new Image
                        {
                            Source="temperament.jpg"
                        },
                        new BoxView
                        {   Color=Color.LightCoral,
                            WidthRequest=400,
                            HeightRequest=50,
                            HorizontalOptions=LayoutOptions.Center,
                            VerticalOptions=LayoutOptions.StartAndExpand
                        },Btn,
                        new Label
                        {
                            Text="ABOUT\ntemperament, in psychology, an aspect of personality concerned with emotional dispositions and reactions and their speed and intensity; the term often is used to refer to the prevailing mood or mood pattern of a person.",
                            FontSize=Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                            HorizontalOptions=LayoutOptions.Center
                        }
                    }
                }
            };
            Children.Add(startpage);
            Children.Add(Melancholic);
            Children.Add(Choleric);
            Children.Add(Sanguine);
            Children.Add(Phlegmatic);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Do you take atest to know your temperament?", "Cancel", "Yes", "No");
            if (result)
            {
                string action = await DisplayActionSheet("Choose a test you want to take", "Cancel", null, "default test (48 questions)(ru)", "Quick test (13 questions)(ru)");
                if (action == "default test (48 questions)(ru)")
                {
                    Uri uri = new Uri("https://testometrika.com/personality-and-temper/questionnaire-eysenck-pen/");
                    await Browser.OpenAsync(uri);
                }
                else if (action == "Quick test (13 questions)(ru)")
                {
                    Test();
                }
            }
            else
            { await DisplayAlert("", "The Solution is canceled", "Ok"); }
        }
    }
}