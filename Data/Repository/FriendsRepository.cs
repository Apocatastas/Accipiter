﻿using Accipiter.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accipiter.Data.Repository
{
    public class FriendsRepository : Repository<Friend>
    {
        public FriendsRepository(ApplicationDbContext db)
      : base(db)
        {
            
        }
        

        public void AddFriend (User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends == null)
            {
                var item = new Friend()
                {
                    UserId = target.Id,
                    User = target,
                    CurrentFriend = Friend,
                    CurrentFriendId = Friend.Id,
                };

                var item_mirrored = new Friend()
                {
                    UserId = Friend.Id,
                    User = Friend,
                    CurrentFriend = target,
                    CurrentFriendId = target.Id,
                };

                Create(item);
                Create(item_mirrored);
            }
        }

        public List<User> GetFriendsByUser(User target)
        {
            var friends = Set.Include(x => x.CurrentFriend).AsEnumerable().Where(x => x.UserId == target.Id).Select(x => x.CurrentFriend);

            return friends.ToList();
        }


        public void DeleteFriend(User target, User Friend)
        {
            var friends = Set.AsEnumerable().FirstOrDefault(x => x.UserId == target.Id && x.CurrentFriendId == Friend.Id);

            if (friends != null)
            {
                Delete(friends);
            }

            var friends_mirrored = Set.AsEnumerable().FirstOrDefault(x => x.UserId == Friend.Id && x.CurrentFriendId == target.Id);

            if (friends_mirrored != null)
            {
                Delete(friends_mirrored);
            }
        }

    }
}
