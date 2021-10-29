using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blokitect.Data.Services
{
    public class LanguageService : Service
    {
        public LanguageService(
            AppDbContext dbContext,
            IMapper mapper,
            IConfigurationProvider configurationProvider) : base(dbContext, mapper, configurationProvider)
        {

        }

        //TODO: AddLanguage() method for adding language to the platform.

        //TODO: DefinePage(LanguageEnum lang, json page) method with the purpose of translating a (section of) page

        //TODO: EditPage(LanguageEnum lang, json page)

        //TODO: DisableLanguage(LanguageEnum lang)

        //TODO: EnableLanguage(LanguageEnum lang)
    }
}
