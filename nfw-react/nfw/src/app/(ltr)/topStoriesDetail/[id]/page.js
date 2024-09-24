"use client";
import TopStoriesDetailPage from '../page'

const TopStoriesDetail = ({ params }) => {


    if (params.id)
        return <TopStoriesDetailPage id={params.id} />;
};

export default TopStoriesDetail