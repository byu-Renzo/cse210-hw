/*
Author: Renzo Rios Rugel
Date: 08/04/2024
*/

class Program
{
    static void Main(string[] args)
    {
        bool isRun = true;

        ResourceManager resourceManager = new ResourceManager();

        while (isRun)
        {
            Console.WriteLine("Welcome to the Learning Resource Manager!");
            Console.WriteLine("\nMenu options: ");
            Console.WriteLine("   1. Add Resource");
            Console.WriteLine("   2. Remove Resource");
            Console.WriteLine("   3. Display All Resources");
            Console.WriteLine("   4. Save Resources");
            Console.WriteLine("   5. Load Resources");
            Console.WriteLine("   6. Open Resource");
            Console.WriteLine("   7. Add Resume to Resource");
            Console.WriteLine("   8. Exit");

            Console.WriteLine();
            Console.Write("Select a choice from menu: ");
            string choice = Console.ReadLine();

            Console.WriteLine();
            if (choice == "1")
            {
                Console.WriteLine("Select the type of resource you want to add: ");
                Console.WriteLine("   1. Book");
                Console.WriteLine("   2. Audio");
                Console.WriteLine("   3. Video");
                Console.WriteLine("   4. Paper");
                Console.WriteLine("   5. Repository");
                Console.WriteLine("   6. Blog");

                Console.WriteLine("");
                Console.Write("Select a choice from menu: ");
                string resourceChoice = Console.ReadLine();

                Console.Write("Enter the title: ");
                string title = Console.ReadLine();
                Console.Write("Enter the description: ");
                string description = Console.ReadLine();
                Console.Write("Enter the url: ");
                string url = Console.ReadLine();

                string creatingDate = DateTime.Now.ToString("yyyy-MM-dd");

                if (resourceChoice == "1")
                {
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter the number of pages: ");
                    int numberOfPages = int.Parse(Console.ReadLine());
                    BookResource book = new BookResource(title, description, url, creatingDate, numberOfPages, author);
                    book.SetResourceType("Book");
                    resourceManager.AddResource(book);
                }
                else if (resourceChoice == "2")
                {
                    Console.Write("Enter the duration: ");
                    int duration = int.Parse(Console.ReadLine());
                    AudioResource audio = new AudioResource(title, description, url, creatingDate, duration);
                    audio.SetResourceType("Audio");
                    resourceManager.AddResource(audio);
                }
                else if (resourceChoice == "3")
                {
                    Console.Write("Enter the duration: ");
                    int duration = int.Parse(Console.ReadLine());
                    VideoResource video = new VideoResource(title, description, url, creatingDate, duration);
                    video.SetResourceType("Video");
                    resourceManager.AddResource(video);
                }
                else if (resourceChoice == "4")
                {
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter the number of pages: ");
                    int numberOfPages = int.Parse(Console.ReadLine());
                    Console.Write("Enter the type: ");
                    string type = Console.ReadLine();
                    PaperResource paper = new PaperResource(title, description, url, creatingDate, numberOfPages, author, type);
                    paper.SetResourceType("Paper");
                    resourceManager.AddResource(paper);
                }
                else if (resourceChoice == "5")
                {
                    Console.Write("Enter the owner: ");
                    string owner = Console.ReadLine();
                    RepositoryResource repository = new RepositoryResource(title, description, url, creatingDate, owner);
                    repository.SetResourceType("Github");
                    resourceManager.AddResource(repository);
                }
                else if (resourceChoice == "6")
                {
                    Console.Write("Enter the author: ");
                    string author = Console.ReadLine();
                    BlogResource blog = new BlogResource(title, description, url, creatingDate, author);
                    blog.SetResourceType("Blog");
                    resourceManager.AddResource(blog);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else if (choice == "2")
            {
                resourceManager.ListResourceNames();
                Console.WriteLine();
                Console.Write("Enter the number of the resource you want to remove: ");
                int resourceNumber = int.Parse(Console.ReadLine());
                LearningResource resource = resourceManager.GetResources()[resourceNumber - 1];

                resourceManager.RemoveResource(resource);
            }
            else if (choice == "3")
            {
                resourceManager.DisplayAllResources();
            }
            else if (choice == "4")
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                resourceManager.SaveResources(fileName);
            }
            else if (choice == "5")
            {
                Console.Write("Enter the file name: ");
                string fileName = Console.ReadLine();
                resourceManager.LoadResources(fileName);
            }
            else if (choice == "6")
            {
                resourceManager.ListResourceNames();
                Console.WriteLine();
                Console.Write("Enter the number of the resource you want to open: ");
                int resourceNumber = int.Parse(Console.ReadLine());
                LearningResource resource = resourceManager.GetResources()[resourceNumber - 1];

                Console.WriteLine();
                resource.DisplayDetails();
                resource.Open();
            }
            else if (choice == "7")
            {
                resourceManager.ListResourceNames();
                Console.WriteLine();
                Console.Write("Enter the number of the resource you want to add a resume: ");
                int resourceNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter the resume: ");
                string resume = Console.ReadLine();

                LearningResource resource = resourceManager.GetResources()[resourceNumber - 1];
                resource.SetResume(resume);
            }
            else if (choice == "8")
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                isRun = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}