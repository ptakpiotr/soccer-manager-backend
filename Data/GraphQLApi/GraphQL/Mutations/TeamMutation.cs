﻿

using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;

namespace GraphQLApi.GraphQL.Mutations
{
    public partial class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<AddTeamPayload> AddTeam(AddTeamInput input, [Service(ServiceKind.Resolver)] AppDbContext ctx,
            [Service] IMapper mapper, CancellationToken token)
        {
            TeamModel team = mapper.Map<TeamModel>(input);
            LogoModel logo = mapper.Map<LogoModel>(input);
            ShirtModel firstShirt = mapper.Map<ShirtModel>(input);
            ShirtModel secondShirt = new()
            {
                MainColor = input.SecondMainColor,
                SecondaryColor = input.SecondSecondaryColor,
                Type = input.SecondType,
                IsSecond = true
            };

            using (IDbContextTransaction transaction = await ctx.Database.BeginTransactionAsync(token))
            {
                try
                {
                    await ctx.Teams.AddAsync(team, token);
                    logo.TeamId = team.Id;
                    firstShirt.TeamId = team.Id;
                    secondShirt.TeamId = team.Id;

                    await ctx.Logos.AddAsync(logo, token);
                    await ctx.Shirts.AddAsync(firstShirt, token);
                    await ctx.Shirts.AddAsync(secondShirt, token);

                    team.LogoId = logo.Id;

                    await ctx.SaveChangesAsync(token);
                    await transaction.CommitAsync(token);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync(token);
                }
            }

            return new(team.Id);
        }
    }
}