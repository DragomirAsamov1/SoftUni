﻿namespace P02._Worker_Before
{
    public class Manager
    {
        private readonly IWorker worker;
        public Manager(IWorker worker) {
            this.worker = worker;
        }
        public void Manage() {
            worker.Work();
        }
    }
}
