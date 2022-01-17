using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;

namespace HRCMS.Data
{
    public class BaseRepository
    {
        protected readonly Dynamics _appSettings;
        protected readonly IMapper _mapper;
        protected readonly ILog _logger;
        public BaseRepository(IMapper mapper, IOptions<Dynamics> settings, ILog logger)
        {
            _mapper = mapper;
            _appSettings = settings.Value;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
