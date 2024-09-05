﻿namespace ForumUnifeso.src.API.Model
{

    public class ThreadForum
    {
        public int? Id { get; private set; }
        
        public Post? Topic { get; private set; }

        public int TopicId { get; private set; }

      
        public List<Post> Answers { get; private set; } = new List<Post>();

        public ThreadForum() {}

        public ThreadForum(int id, Post topic)
        {
            Id = id;
            Topic = topic;
        }
    }
}
