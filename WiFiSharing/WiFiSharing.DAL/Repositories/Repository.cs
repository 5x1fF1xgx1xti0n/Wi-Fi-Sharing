namespace WiFiSharing.DAL.Repositories
{
    using AutoMapper;

    internal abstract class Repository
    {
        protected readonly AppDBContext _context;
        protected readonly IMapper _mapper;

        protected Repository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
