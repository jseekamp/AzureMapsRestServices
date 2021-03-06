﻿using AzureMapsToolkit.Common;
using AzureMapsToolkit.GeoJson;
using AzureMapsToolkit.Render;
using AzureMapsToolkit.Search;
using AzureMapsToolkit.Timezone;
using AzureMapsToolkit.Traffic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzureMapsToolkit
{
    public interface IAzureMapsServices
    {

        Task<Response<Geolocation.IpAddressToLocationResult>> GetIPToLocation(string ip, string apiVersion = "1.0");

        Task<Response<Render.CopyrightCaptionResult>> GetCopyrightCaption(string apiVersion = "1.0");

        Task<Response<Render.CopyrightResult>> GetCopyrightForTile(CopyrightForTileRequest req);
        
        Task<Response<Render.CopyrightResult>> GetCopyrightForWorld(string apiVersion = "1.0");

        Task<Response<Render.CopyrightResult>> GetCopyrightFromBoundingBox(CopyrightFromBoundingBoxRequest req);

        Task<Response<byte[]>> GetMapImage(MapImageRequest req);

        Task<Response<byte[]>> GetMapImageryTile(MapImageryTileRequest req);

        Task<Response<byte[]>> GetMapTile(MapTileRequest req);

        Task<Response<RouteDirectionsResponse>> GetRouteDirections(RouteRequestDirections routeReq);

        Task<Response<RouteRangeResponse>> GetRouteRange(RouteRangeRequest routeRequest);

        Task<(string ResultUrl, Exception ex)> GetRouteDirections(IEnumerable<RouteRequestDirections> routeRequestItems);

        Task<(RouteMatrixResponse matrix, Exception ex)> GetRouteMatrix(RouteMatrixRequest routeMatrixRequest, IEnumerable<Coordinate> coordinatesOrigins, IEnumerable<Coordinate> coordinatesDestinations);

        Task<Response<SearchAddressResponse>> GetSearchAddress(SearchAddressRequest searchAddressRequest);

        Task<Response<SearchAddressReverseResponse>> GetSearchAddressReverse(SearchAddressReverseRequest request);

        Task<Response<SearchAddressReverseCrossStreetResponse>> GetSearchAddressReverseCrossStreet(SearchAddressReverseCrossStreetRequest request);

        Task<Response<SearchAddressStructuredResponse>> GetSearchAddressStructured(SearchAddressStructuredRequest req);

        Task<Response<SearchFuzzyResponse>> GetSearchFuzzy(SearchFuzzyRequest req);

        Task<Response<SearchNearbyResponse>> GetSearchNearby(SearchNearbyRequest req);

        Task<Response<SearchPoiResponse>> GetSearchPoi(SearchPoiRequest req);

        Task<Response<SearchPoiCategoryResponse>> GetSearchPOICategory(SearchPoiCategoryRequest req);

        Task<(string ResultUrl, Exception ex)> GetSearchAddress(IEnumerable<SearchAddressRequest> req);

        Task<(string ResultUrl, Exception ex)> GetSearchAddressReverse(IEnumerable<SearchAddressReverseRequest> req);

        Task<Response<SearchAlongRouteResponse>> GetSearchAlongRoute(SearchAlongRouteRequest req, LineString lineString);

        Task<(string ResultUrl, Exception ex)> GetSearchFuzzy(IEnumerable<SearchFuzzyRequest> req);

        Task<Response<SearchGeometryResponse>> GetSearchInsidePolygon(SearchInsidePolygonRequest request, Object geoJson);

        Task<Response<TimezoneResult>> GetTimezoneByCoordinates(TimeZoneRequest req);

        Task<Response<TimezoneResult>> GetTimezoneById(TimeZoneRequest req);

        Task<Response<IEnumerable<IanaId>>> GetTimezoneEnumIANA();

        Task<Response<IEnumerable<TimezoneEnumWindow>>> GetTimezoneEnumWindows();

        Task<Response<TimezoneIanaVersionResult>> GetTimezoneIANAVersion();

        Task<Response<IEnumerable<IanaId>>> GetTimezoneWindowsToIANA(TimezoneWindowsToIANARequest req);

        Task<Response<TrafficFlowSegmentResult>> GetTrafficFlowSegment(TrafficFlowSegmentRequest req);

        Task<Response<byte[]>> GetTrafficFlowTile(TrafficFlowTileRequest req);

        Task<Response<TrafficIncidentDetailResult>> GetTrafficIncidentDetail(TrafficIncidentDetailRequest req);

        Task<Response<byte[]>> GetTrafficIncidentTile(TrafficIncidentTileRequest req);

        Task<Response<TrafficIncidentViewportResult>> GetTrafficIncidentViewport(TrafficIncidentViewportRequest req);


    }
}
