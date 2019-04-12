using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BenChainClient.Api.DbEntities;
using BenChainClient.Api.Models;

namespace BenChainClient.Api.Config
{
  public class BenChainPortfolioAutoMapperConfig
  {
    public static void Init()
    {
      Mapper.Initialize(cfg =>
      {
        IgnoreNullValues(cfg);
        InitDb(cfg);
      });
    }

    /// <summary>
    /// Don't override target member's value when source value is null
    /// </summary>
    /// <param name="profileExpression"></param>
    private static void IgnoreNullValues(IProfileExpression profileExpression)
    {
      profileExpression.ForAllPropertyMaps(propertyMap =>
          Attribute.IsDefined(propertyMap.SourceMember, typeof(DoNotMapNullOrDefaultValueAttribute)),
        (propertyMap, memberConfigurationExpression) =>
        {
          memberConfigurationExpression.Condition((source, destination, sourceValue) =>
            sourceValue != null);
            //&& !sourceValue.IsDefault());
        });
    }

    private static void InitDb(IProfileExpression cfg)
    {
      cfg.CreateMap<Participant, ParticipantModel>();
      cfg.CreateMap<ParticipantModel, Participant>();
    }
  }
}