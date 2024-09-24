"use client";
import LatestArticlesDetailPage from '../page'

const LatestArticlesDetail = ({ params }) => {


    if (params.id)
        return <LatestArticlesDetailPage id={params.id} />;
};

export default LatestArticlesDetail