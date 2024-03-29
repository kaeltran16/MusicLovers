﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicLovers.Core.Contracts;
using MusicLovers.Core.Contracts.Repositories.Contracts;
using MusicLovers.Core.Models;
using MusicLovers.Repositories;

namespace MusicLovers.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IGigRepository Gigs { get; private set; }
        public IGenreRepository Genres { get; private set; }
        public IFollowingRepository Followings { get; private set; }
        public IAttendanceRepository Attendances { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(_context);
            Genres = new GenreRepository(_context);
            Followings = new FollowingRepository(_context);
            Attendances = new AttendanceRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}