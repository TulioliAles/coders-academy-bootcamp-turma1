﻿using CodersAcademy.API.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodersAcademy.API.Repository
{
    public class AlbumRepository
    {
        private MusicContext Context { get; set; }
        public AlbumRepository(MusicContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Album>> GetAllAsync()
            => await this.Context.Albums.Include(x => x.Musics).ToListAsync();

        public async Task<Album> GetAlbumByIdAsync(Guid id)
            => await this.Context.Albums.Include(x => x.Id == id).FirstOrDefaultAsync();

        public async Task DeleteAsync(Album model)
        {
            this.Context.Remove(model);
            await this.Context.SaveChangesAsync(); //TEM QUE TER A CHAMADA DO SAVE CHANGES!!!!!!!!!
        }

        public async Task CreateAsync(Album album)
        {
            await this.Context.Albums.AddAsync(album);
            await this.Context.SaveChangesAsync(); //TEM QUE TER A CHAMADA DO SAVE CHANGES!!!!!!!!!
        }
    }
}
