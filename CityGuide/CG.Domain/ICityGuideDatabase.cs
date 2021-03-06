﻿using System.Collections.Generic;

namespace CG.Domain
{
    public interface ICityGuideDatabase
    {
        List<Objective> GetAllObjectives();
        List<Objective> GetObjectivesFromCategory(int id);
        List<Category> GetAllCategories();
        List<Review> GetAllReviews();
        Objective GetObjectiveByID(int ObjectiveID);
        User GetUserFromFacebookID(string FacebookID);
        List<Tour> GetAllTours();
        List<Objective> GetObjectivesForTour(int id);
        List<Transport> GetTransportsForTour(int id);
        int GetLastTourId();
        Tour GetTourById(int id);

        void Commit();
    }
}
